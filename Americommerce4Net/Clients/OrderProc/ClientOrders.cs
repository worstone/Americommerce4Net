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
    public class ClientOrders : BaseNestedClient, IClientOrderStatus
    {
        protected internal ClientOrders(IRestEngine restEngine)
            : base(restEngine) {
            base.ResourceName = "orders";
        }
        
        /// <summary>
        /// To update the status of an order and trigger order-status-changed events 
        /// such as sending notification emails to customers, a special endpoint must be used.
        /// Sample: new { order_status_id = 3} // Anonymous Type
        /// </summary>
        /// <param name="recordId">Order id</param>
        /// <param name="obj">Object or Anonymous Type</param>
        /// <returns></returns>
        public IClientResponse<dynamic> UpdateStatus(int recordId, object obj) {
            return UpdateStatus(recordId, obj.ObjectToJson());
        }

        /// <summary>
        /// To update the status of an order and trigger order-status-changed events 
        /// such as sending notification emails to customers, a special endpoint must be used.
        /// Sample: {"order_status_id": 3} // json
        /// </summary>
        /// <param name="recordId">Order id</param>
        /// <param name="json">json</param>
        /// <returns></returns>
        public IClientResponse<dynamic> UpdateStatus(int recordId, string json) {
            string endpoint = string.Format("/{0}/{1}/{2}", ResourceName, recordId, "status");
            return _RestEngine.PutData<dynamic>(endpoint, json);
        }
    }
}