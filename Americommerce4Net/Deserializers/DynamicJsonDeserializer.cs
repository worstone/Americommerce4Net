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

using Americommerce4Net.Logging;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace Americommerce4Net.Deserializers
{
    public class DynamicJsonDeserializer : IDeserializer
    {
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public T Deserialize<T>(IRestResponse response) {

            if (response.StatusCode == System.Net.HttpStatusCode.OK ||
                response.StatusCode == System.Net.HttpStatusCode.Created ||
                response.StatusCode == System.Net.HttpStatusCode.Accepted ||
                response.StatusCode == System.Net.HttpStatusCode.NoContent) {

                try {
                    return JsonConvert.DeserializeObject<dynamic>(response.Content);

                } catch (JsonSerializationException ex) {
                    LoggingService.Log(this).ErrorFormat("DynamicJsonDeserializer | {0}", response.ResponseUri, ex);
                    throw new DeserializerException(ex.Message) { RestResponse = response };
                }
            } else {
                LoggingService.Log(this).ErrorFormat("DynamicJsonDeserializer | {0}", response.ResponseUri, response.ErrorException.Message);
                throw new DeserializerException(response.ErrorException.Message) { RestResponse = response };
            }
        }
    }
}
