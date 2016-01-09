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
    public class Order : BaseAudit, IResource
    {
        public Order() {
            items = new List<Order_Item>();
            payments = new List<Order_Payment>();
            shipments = new List<Order_Shipment>();
            custom_fields = new List<Order_Custom_Field>();
        }

        public int id { get; set; }
        public int customer_id { get; set; }
        public int customer_type_id { get; set; }
        public string adcode { get; set; }
        public DateTime? ordered_at { get; set; }
        public int order_status_id { get; set; }
        public string special_instructions { get; set; }
        public decimal subtotal { get; set; }
        public decimal tax_total { get; set; }
        public decimal shipping_total { get; set; }
        public decimal discount_total { get; set; }
        public decimal grand_total { get; set; }
        public decimal cost_total { get; set; }
        public string selected_shipping_method { get; set; }
        public string ip_address { get; set; }
        public string referrer { get; set; }
        public int? order_shipping_address_id { get; set; }
        public int? order_billing_address_id { get; set; }
        public string admin_comments { get; set; }
        public string source { get; set; }
        public string search_phrase { get; set; }
        public bool is_ppc { get; set; }
        public string ppc_keyword { get; set; }
        public int? affiliate_id { get; set; }
        public int store_id { get; set; }
        public int session_id { get; set; }
        public decimal handling_total { get; set; }
        public bool is_payment_order_only { get; set; }
        public string selected_shipping_provider_service { get; set; }
        public decimal additional_fees { get; set; }
        public int adcode_id { get; set; }
        public bool is_gift { get; set; }
        public string gift_message { get; set; }
        public string public_comments { get; set; }
        public string instructions { get; set; }
        public string source_group { get; set; }
        public int? from_subscription_id { get; set; }
        public int previous_order_status_id { get; set; }
        public DateTime? order_status_last_changed_at { get; set; }
        public decimal? discounted_shipping_total { get; set; }
        public string order_number { get; set; }
        public string coupon_code { get; set; }
        public string order_type { get; set; }
        public DateTime? expires_at { get; set; }
        public bool expires { get; set; }
        public int? from_quote_id { get; set; }
        public string campaign_code { get; set; }
        public bool reward_points_credited { get; set; }

        public List<Order_Item> items { get; set; }
        public List<Order_Payment> payments { get; set; }
        public List<Order_Shipment> shipments { get; set; }
        public List<Order_Custom_Field> custom_fields { get; set; }

    }

}
