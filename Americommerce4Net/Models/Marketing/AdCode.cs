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
    public class AdCode : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int visits { get; set; }
        public int affiliate_id { get; set; }
        public string commission { get; set; }
        public string commission_type { get; set; }
        public object total_sales { get; set; }
        public object total_orders { get; set; }
        public object initial_sales { get; set; }
        public object load_sales { get; set; }
        public object new_customers { get; set; }
        public object load_customers { get; set; }
        public object total_commissions { get; set; }
        public object conversion_rate { get; set; }
        public object cost_per_customer { get; set; }
        public object sales_per_ad_dollar { get; set; }
        public string repeat_commission_amount { get; set; }
        public string repeat_commission_type { get; set; }
        public string pay_for_repeat_sales { get; set; }
        public string url { get; set; }
        public bool is_pay_per_click { get; set; }
        public string source { get; set; }
        public string expires_at { get; set; }
        public string creation_type { get; set; }
    }
}