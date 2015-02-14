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

using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Clients
{
    public class BaseClient : Americommerce4Net.IClientRead
    {
        public string ResourceName { get; protected set; }

        public bool CachingOn {
            get {
                return _RestEngine.CachingOn;
            }
            set {
                _RestEngine.CachingOn = value;
            }
        }
        
        protected internal IRestEngine _RestEngine;

        protected internal BaseClient(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public IClientResponse<dynamic> Get(int recordId) {
            return Get(recordId, (FilterSingle)null);
        }

        public IClientResponse<dynamic> Get(FilterList filter) {
            return Get(filter, ResourceName);
        }

        public IClientResponse<dynamic> Get(int recordId, FilterSingle filter) {
            return Get(recordId, filter, ResourceName);
        }

        public IClientResponse<dynamic> Get(FilterMultiId filter) {
            return Get(filter, ResourceName);
        }

        //Get
        protected IClientResponse<dynamic> Get(FilterList filter, string resource) {
            string endpoint = string.Format("/{0}", resource);
            return _RestEngine.GetData<dynamic>(endpoint, filter);
        }

        protected IClientResponse<dynamic> Get(int recordId, FilterSingle filter, string resource) {
            string endpoint = string.Format("/{0}/{1}", resource, recordId);
            return _RestEngine.GetData<dynamic>(endpoint, filter);
        }

        protected IClientResponse<dynamic> Get(FilterMultiId filter, string resource) {
            string endpoint = string.Format("/{0}/select_many", resource);
            return _RestEngine.GetData<dynamic>(endpoint, filter);
        }

        protected IClientResponse<dynamic> Get(int recordId, FilterSingleNested filter, string resource) {
            string endpoint = string.Format("/{0}/{1}/filled",resource, recordId);
            return _RestEngine.GetData<dynamic>(endpoint, filter);
        }

        protected IClientResponse<dynamic> Get(int recordId, string nestedResource, FilterNestedOnly filter, string resource) {
            string endpoint = string.Format("/{0}/{1}/{2}",resource, recordId, nestedResource);
            return _RestEngine.GetData<dynamic>(endpoint, filter);
        }

        //Update
        protected IClientResponse<dynamic> Update(int recordId, object obj, string resource) {
            return Update(recordId, obj.ObjectToJson(), resource);
        }
        protected IClientResponse<dynamic> Update(int recordId, string json, string resource) {
            string endpoint = string.Format("/{0}/{1}", resource, recordId);
            return _RestEngine.PutData<dynamic>(endpoint, json);
        }

        //Create
        protected IClientResponse<dynamic> Create(object obj, string resource) {
            return Create(obj.ObjectToJson(), resource);
        }
        protected IClientResponse<dynamic> Create(string json, string resource) {
            string endpoint = string.Format("/{0}", resource); 
            return _RestEngine.PostData<dynamic>(endpoint, json);
        }

        //Delete
        protected IClientResponse<bool> Delete(int recordId, string resource) {
            string endpoint = string.Format("/{0}/{1}", resource, recordId);
            return _RestEngine.DeleteData(endpoint);
        }
    }
}
