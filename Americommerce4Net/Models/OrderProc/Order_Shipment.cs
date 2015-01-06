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

namespace Americommerce4Net.Models
{
    public class Order_Shipment : BaseAudit, IResource
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public DateTime? shipped_at { get; set; }
        public string tracking_numbers { get; set; }
        public string tracking_url { get; set; }
        public string shipping_method { get; set; }
        public int shipping_method_id { get; set; }
        public int? number_of_packages { get; set; }
        public decimal? total_weight { get; set; }
        public string provider_base_shipping_cost { get; set; }
        public decimal? provider_insurance_cost { get; set; }
        public decimal? provider_handling_cost { get; set; }
        public decimal? provider_total_shipping_cost { get; set; }
        public bool email_sent { get; set; }
        public string private_comment { get; set; }
        public string shipping_comment { get; set; }
        public string shipping_method_type { get; set; }
        public string shipment_name { get; set; }
    }

}