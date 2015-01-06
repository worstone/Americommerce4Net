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

using System.Collections.Generic;

namespace Americommerce4Net.Clients
{
    public class BaseNonNestedClient : BaseCRUDClient
    {
        protected internal BaseNonNestedClient(IRestEngine restEngine)
            : base(restEngine) { }

        ////Update
        //public IClientResponse<dynamic> Update(int recordId, object obj) {
        //    return base.Update(recordId, obj, ResourceName);
        //}
        //public IClientResponse<dynamic> Update(int recordId, string json) {
        //    return base.Update(recordId, json, ResourceName);
        //}

        ////Create
        //public IClientResponse<T> Create<T>(Product obj) where T : Product, new() {
        //    return Create<T>(obj.ObjectToJson());
        //}
        //public IClientResponse<T> Create<T>(string json) where T : Product, new() {
        //    string resourceEndpoint = "/products";
        //    return _RestEngine.PostData<T>(resourceEndpoint, json);
        //}

        ////Delete
        //public IClientResponse<bool> Delete(int recordId) {
        //    string resourceEndpoint = string.Format("/products/{0}", recordId);
        //    return _RestEngine.DeleteData(resourceEndpoint);
        //}
    }
}
