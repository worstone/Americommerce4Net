#region License
//   Copyright 2015 Ken Worst - R.C. Worst & Company Inc.
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

using System.Collections.Generic;
using Americommerce4Net.ExtensionMethods;
using System;

namespace Americommerce4Net.Repositories
{
    public abstract class BaseRepoRead<T> : Americommerce4Net.IRepoRead<T>, Americommerce4Net.IRepo
    {
        private string _ResourceName;
        protected string ResourceName {
            get {
                return _ResourceName;
            }
        }
        
        private IClientRead _ReadClient;
        protected IClientRead ReadClient {
            get {
                return _ReadClient;
            }
        }

        public CacheControl CacheControl {
            get { return _ReadClient.CacheControl; }
            set { _ReadClient.CacheControl = value; }
        }

        protected BaseRepoRead(IClientRead client, string resourceName) {
            _ReadClient = client;
            _ResourceName = resourceName;
        }

        //Get's
        public virtual IRepoResponse<T> Get(int id) {
            var response = ReadClient.Get(id);

            var repo_response = new RepoResponse<T>();
            try {
                repo_response.Data = response.Data.ToObject<T>();
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }
            
            return repo_response;
        }

        public virtual IRepoResponse<T> Get(int id, FilterSingle filter) {
            var response = ReadClient.Get(id, filter);

            var repo_response = new RepoResponse<T>();
            try {
                repo_response.Data = response.Data.ToObject<T>();
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }
            
            return repo_response;
        }

        public virtual IRepoResponse<List<T>> Get(FilterMultiId filter) {
            var response = ReadClient.Get(filter);

            var repo_response = new RepoResponse<List<T>>();
            repo_response.Data = new List<T>();
            try {
                foreach (var item in response.Data[ResourceName]) {
                    repo_response.Data.Add(item.ToObject<T>());
                }
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }

            return repo_response;
        }

        //GetAll's
        public virtual IRepoResponse<List<T>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThanOrEqual());

            return RecordPaging(filter);
        }
        

        public virtual IRepoResponse<List<T>> GetAll(FilterList filter) {
            return RecordPaging(filter);
        }

        //Get_GreaterThanOrEqualTo_ModifiedDate
        public virtual IRepoResponse<List<T>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual());

            return RecordPaging(filter);
        }

        

        protected IRepoResponse<List<T>> RecordPaging(FilterList filterList) {


            var repo_response = new RepoResponse<List<T>>();
            repo_response.Data = new List<T>();
            

            var items = new List<T>();

            int total_count = 0;
            int page_count = 0;
            int page_current = 1;
            int records_per_page = 100;

            do {
                var response = ReadClient.Get(filterList
                .Page(page_current)
                .Count(records_per_page));
                repo_response.ErrorException = response.RestResponse.ErrorException;
                if (response.RestResponse.ErrorException == null) {
                    if (response.RestResponse.StatusCode == System.Net.HttpStatusCode.OK) {
                        if (page_current == 1) {
                            total_count = (int)response.Data["total_count"].Value;

                            var pageCount = total_count / records_per_page;
                            var remainingCount = total_count % records_per_page;
                            if (remainingCount > 0) {
                                page_count = pageCount + 1;
                            } else {
                                page_count = pageCount;
                            }
                        }
                        try {
                            foreach (var item in response.Data[ResourceName]) {
                                repo_response.Data.Add(item.ToObject<T>());
                            }
                        } catch (Exception ex) {
                            repo_response.ErrorException = ex;
                            return repo_response;
                        }
                        page_current++;
                    } else {
                        repo_response.ErrorException = new Exception(string.Format("Unexpected  HttpStatusCode - {0}", response.RestResponse.StatusCode));
                        break;
                    }
                }

            } while (page_current <= page_count);

            return repo_response;
        }


        
    }
}