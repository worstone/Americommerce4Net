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
    public class Order_Item : BaseAudit, IResource
    {
        public Order_Item() {
            variants = new List<Order_Item_Variant>();
            personalizations = new List<Order_Item_Personalization>();
        }
        public int id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set; }
        public string item_number { get; set; }
        public string item_name { get; set; }
        public decimal? price { get; set; }
        public decimal? cost { get; set; }
        public int quantity { get; set; }
        public bool is_discount_item { get; set; }
        public decimal? weight { get; set; }
        public bool is_taxable { get; set; }
        public string weight_unit { get; set; }
        public int? parent_order_item_id { get; set; }
        public bool is_quantity_bound_to_parent { get; set; }
        public decimal? height { get; set; }
        public decimal? length { get; set; }
        public decimal? width { get; set; }
        public string size_unit { get; set; }
        public string admin_comments { get; set; }
        public bool do_not_discount { get; set; }
        public string line_item_note { get; set; }
        public string gift_message { get; set; }
        public DateTime? delivery_date { get; set; }
        public bool is_subscription_product { get; set; }
        public int warehouse_id { get; set; }
        public string description { get; set; }
        public List<Order_Item_Variant> variants { get; set; }
        public List<Order_Item_Personalization> personalizations { get; set; }
    }
}
