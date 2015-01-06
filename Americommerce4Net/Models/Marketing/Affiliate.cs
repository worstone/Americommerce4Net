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
    public class Affiliate : BaseAudit, IResource
    {
        public int id { get; set; }
        public object affiliate_status { get; set; }
        public string email { get; set; }
        public string affiliate_code { get; set; }
        public string name { get; set; }
        public string urls { get; set; }
        public string origin { get; set; }
        public string description { get; set; }
        public object commission_amount { get; set; }
        public string commission_type { get; set; }
        public string pay_for_repeat_sales { get; set; }
        public object repeat_commission_amount { get; set; }
        public string repeat_commission_type { get; set; }
        public object last_statement_at { get; set; }
        public string payee_name { get; set; }
        public string payee_address_line_1 { get; set; }
        public string payee_address_line_2 { get; set; }
        public string payee_address_line_3 { get; set; }
        public string payee_city { get; set; }
        public string payee_state { get; set; }
        public string payee_postal_code { get; set; }
        public object payee_country { get; set; }
        public string payee_phone { get; set; }
        public string payee_tax_id { get; set; }
        public string payee_tax_registration_name { get; set; }
        public string payee_tax_classification { get; set; }
        public string contact_name { get; set; }
        public string contact_address_line_1 { get; set; }
        public string contact_address_line_2 { get; set; }
        public string contact_address_line_3 { get; set; }
        public string contact_city { get; set; }
        public string contact_state { get; set; }
        public string contact_postal_code { get; set; }
        public object contact_country { get; set; }
        public string contact_phone { get; set; }
        public object total_visitors { get; set; }
        public object total_sales { get; set; }
        public object total_orders { get; set; }
        public object new_customers { get; set; }
        public object total_commissions { get; set; }
        public object conversion_rate { get; set; }
        public object store_id { get; set; }
    }
}
