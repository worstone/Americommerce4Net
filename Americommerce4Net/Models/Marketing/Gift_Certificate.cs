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

namespace Americommerce4Net.Models
{
    public class Gift_Certificate : BaseAudit, IResource
    {
        public int id { get; set; }
        public string code { get; set; }
        public object original_order_id { get; set; }
        public object from_customer_id { get; set; }
        public string recipient_email { get; set; }
        public string recipient_name { get; set; }
        public string recipient_shipping_address { get; set; }
        public string gift_message { get; set; }
        public string status { get; set; }
        public bool is_pre_tax_discount { get; set; }
        public string gift_certificate_type { get; set; }
        public string comments { get; set; }
        public string expires_at { get; set; }
        public int store_id { get; set; }
        public int current_amount { get; set; }
        public int original_amount { get; set; }
        public int customer_id { get; set; }
        public bool expires { get; set; }
        public object order_item_id { get; set; }
    }
}
