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
using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Clients
{
    public class BaseCRUDClient : BaseClient, Americommerce4Net.IClientReadWrite
    {
        protected internal BaseCRUDClient(IRestEngine restEngine)
            : base(restEngine) { }

        //Update
        public IClientResponse<dynamic> Update(int recordId, object obj) {
            return base.Update(recordId, obj, ResourceName);
        }
        public IClientResponse<dynamic> Update(int recordId, string json) {
            return base.Update(recordId, json, ResourceName);
        }

        //Create
        public IClientResponse<dynamic> Create(object obj) {
            return base.Create(obj.ObjectToJson(), ResourceName);
        }
        public IClientResponse<dynamic> Create(string json) {
            return base.Create(json, ResourceName);
        }

        //Delete
        public IClientResponse<bool> Delete(int recordId) {
            return base.Delete(recordId, ResourceName);
        }
    }
}
