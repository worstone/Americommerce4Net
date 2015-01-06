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
    public class Order_Payment : BaseAudit, IResource
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int order_id { get; set; }
        public int customer_payment_method_id { get; set; }
        public int payment_method_id { get; set; }
        public string payment_type { get; set; }
        public bool is_approved { get; set; }
        public bool is_declined { get; set; }
        public string card_type { get; set; }
        public int card_expiration_month { get; set; }
        public int card_expiration_year { get; set; }
        public string cardholder_name { get; set; }
        public DateTime? paid_at { get; set; }
        public DateTime? approved_at { get; set; }
        public string authorization_code { get; set; }
        public string reject_reason { get; set; }
        public string avs_code { get; set; }
        public string payment_method_name { get; set; }
        public string transaction_type { get; set; }
        public decimal amount { get; set; }
        public string payment_note { get; set; }
        public int? gift_certificate_id { get; set; }
        public bool is_captured { get; set; }
        public string transaction_id { get; set; }
        public bool is_void { get; set; }
        public string gateway_response_code { get; set; }
        public string cvv_response_code { get; set; }
    }
}
