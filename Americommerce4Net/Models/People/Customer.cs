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
using System.Collections.Generic;

namespace Americommerce4Net.Models
{
    public class Customer : BaseAudit, IResource
    {
        public Customer(){
            addresses = new List<Customer_Address>();
            custom_fields = new List<Customer_Custom_Field>();
            reward_points = new List<Customer_Reward_Points>();
        }

        public int id { get; set; }
        public string customer_number { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime? registered_at { get; set; }
        public DateTime? last_visit_at { get; set; }
        public string adcode { get; set; }
        public int? adcode_id { get; set; }
        public int? affiliate_id { get; set; }
        public int? customer_type_id { get; set; }
        public bool is_no_tax_customer { get; set; }
        public string comments { get; set; }
        public int store_id { get; set; }
        public string source { get; set; }
        public string search_string { get; set; }
        public bool no_account { get; set; }
        public string sales_person { get; set; }
        public string alternate_phone_number { get; set; }
        public bool is_affiliate_customer { get; set; }
        public string username { get; set; }
        public bool is_contact_information_only { get; set; }
        public string tax_exemption_number { get; set; }
        public string company { get; set; }
        public string source_group { get; set; }

        public List<Customer_Address> addresses { get; set; }
        public List<Customer_Custom_Field> custom_fields { get; set; }
        public List<Customer_Reward_Points> reward_points { get; set; }

    }
}