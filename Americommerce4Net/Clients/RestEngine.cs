#region License
//   Copyright 2014 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System;
using System.Linq;
using RestSharp;
using Americommerce4Net.Logging;

namespace Americommerce4Net.Clients
{
    public class RestEngine : IRestEngine
    {

        private readonly Configuration _Configuration;
        int _ErrorDeserializeRetryCount = 0;

        internal RestEngine(Configuration _configuration) {
            _Configuration = _configuration;
        }

        public IClientResponse<T> GetData<T>(string resourceEndpoint) where T : new() {

            return GetData<T>(resourceEndpoint, null);
        }

        public IClientResponse<T> GetData<T>(string resourceEndpoint, IFilter filter) where T : new() {

            var request = new RestRequest(resourceEndpoint);

            if (filter != null) {
                filter.AddFilter(request);
            }

            var clientResponse = new ClientResponse<T>();

            var response = RestExecute<T>(request, Method.GET);

            clientResponse.RestResponse = response;

            if (response.Data != null) {
                clientResponse.Data = response.Data;
                clientResponse.HttpResponse = response.StatusCode;
            }

            return (IClientResponse<T>)clientResponse;
        }

        public IClientResponse<T> PutData<T>(string resourceEndpoint, string json) where T : new() {

            var request = new RestRequest(resourceEndpoint);

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            var clientResponse = new ClientResponse<T>();

            var response = RestExecute<T>(request, Method.PUT);

            clientResponse.RestResponse = response;

            if (response.Data != null) {
                clientResponse.Data = response.Data;
                clientResponse.HttpResponse = response.StatusCode;
            }

            return clientResponse;
        }

        public IClientResponse<T> PostData<T>(string resourceEndpoint, string json) where T : new() {

            var request = new RestRequest(resourceEndpoint);

            request.AddParameter("application/json", json, ParameterType.RequestBody);

            var clientResponse = new ClientResponse<T>();

            var response = RestExecute<T>(request, Method.POST);

            clientResponse.RestResponse = response;

            if (response.Data != null) {
                clientResponse.Data = response.Data;
                clientResponse.HttpResponse = response.StatusCode;
            }

            return clientResponse;
        }

        public IClientResponse<bool> DeleteData(string resourceEndpoint) {

            IClientResponse<bool> clientResponse = null;

            //Just making sure you want to delete data --just for little extra safety
            if (_Configuration.AllowDeletions) {

                var request = new RestRequest(resourceEndpoint);

                var response = RestExecute<object>(request, Method.DELETE);

                clientResponse = new ClientResponse<bool>() {
                    RestResponse = response,
                    Data = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false,
                    HttpResponse = response.StatusCode
                };

            } else {
                clientResponse = new ClientResponse<bool>() {
                    RestResponse = null,
                    Data = false,
                    HttpResponse = System.Net.HttpStatusCode.NotAcceptable
                };
            }

            return clientResponse;
        }
        
        private IRestResponse<T> RestExecute<T>(IRestRequest request, Method method) where T : new() {
            
            request.Method = method;
            
            var restClient = new RestClient(_Configuration.ServiceURL);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("X-AC-Auth-Token", _Configuration.ApiAccessToken);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddParameter("Accept", "application/json", ParameterType.HttpHeader);

            restClient.AddHandler("application/json", new Deserializers.DynamicJsonDeserializer());
            
            restClient.Timeout = _Configuration.RequestTimeout;
            restClient.UserAgent = "Americommerce4Net";

            IRestResponse<T> response = null;

            do {
                try {
                    response = restClient.Execute<T>(request);

                    if (_ErrorDeserializeRetryCount > 0) {
                        ResponseLogging(response, restClient.GetType());
                    }
                    CheckForThrottling(response);
                    _ErrorDeserializeRetryCount = 0;
                } catch (DeserializerException ex) {
                    _ErrorDeserializeRetryCount++;

                    if (_ErrorDeserializeRetryCount >= _Configuration.ErrorRetryMax) {
                        _ErrorDeserializeRetryCount = 0;
                        LoggingService.Log(this).Error(ex.Message, ex);
                        response.ErrorException = ex;
                        response.ErrorMessage = ex.Message;

                    }
                    System.Threading.Thread.Sleep(_Configuration.ErrorRetryDelay);

                } catch (Exception ex) {
                    _ErrorDeserializeRetryCount = 0;
                    LoggingService.Log(this).Error(ex.Message, ex);
                    response.ErrorException = ex;
                    response.ErrorMessage = ex.Message;
                }
            } while (_ErrorDeserializeRetryCount > 0);

            if (_Configuration.EnableInfoLogging) {
                ResponseLogging(response, restClient.GetType());
            }
            return response;
        }

        private void CheckForThrottling(IRestResponse response) {
            if (_Configuration.ThrottlingEnabled) {
                var head = response.Headers.Where(x => x.Name == "X-AC-Call-Limit").FirstOrDefault();
                if (head != null && head.Value != null) {
                    
                    int currentlimit;
                    int maxlimit;

                    bool currentlimit_wasParsed;
                    bool maxlimit_wasParsed;
                    
                    
                    string[] api_limit = head.Value.ToString().Split('/');

                    currentlimit_wasParsed = int.TryParse(api_limit[0].ToString(), out currentlimit);
                    maxlimit_wasParsed = int.TryParse(api_limit[1].ToString(), out maxlimit);


                    if (currentlimit_wasParsed && maxlimit_wasParsed) {
                        if (currentlimit >= maxlimit) {

                            LoggingService.Log(this).WarnFormat("Throttling Enabled Until Call Limit Gets Above {0} - {1}", maxlimit, head);
                            System.Threading.Thread.Sleep(_Configuration.ThrottlingDelay);
                        }
                    }
                }
            }
        }

        private void ResponseLogging(IRestResponse response, Type type) {

            string apiLimit = string.Empty;

            var head = response.Headers.Where(x => x.Name == "X-AC-Call-Limit").FirstOrDefault();
            if (head != null && head.Value != null) {
                apiLimit = head.Value.ToString();
            }

            if (response.StatusCode == System.Net.HttpStatusCode.OK ||
                response.StatusCode == System.Net.HttpStatusCode.Created ||
                response.StatusCode == System.Net.HttpStatusCode.Accepted ||
                response.StatusCode == System.Net.HttpStatusCode.NoContent) {

                LoggingService.Log(this).InfoFormat("[{0}] - Uri:{1} | HTTP Response Code:{2} - {3} | X-AC-Call-Limit: {4}",
                    type.Name,
                    response.ResponseUri,
                    (int)response.StatusCode,
                    response.StatusDescription,
                    apiLimit);

            } else {

                LoggingService.Log(this).ErrorFormat("[{0}] - Uri:{1} | HTTP Response Code:{2} - {3} | X-AC-Call-Limit: {4} | Response Content:[{5}]",
                    type.Name,
                    response.ResponseUri,
                    (int)response.StatusCode,
                    response.StatusDescription,
                    apiLimit,
                    response.Content);
            }
        }
    }
}
