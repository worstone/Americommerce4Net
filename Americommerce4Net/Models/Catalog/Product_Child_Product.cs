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
    public class Product_Child_Product : BaseAudit, IResource
    {
        public int id { get; set; }
        public string item_number { get; set; }
        public int supplier_id { get; set; }
        public int manufacturer_id { get; set; }
        public string manufacturer_part_number { get; set; }
        public int primary_category_id { get; set; }
        public int product_status_id { get; set; }
        public string item_name { get; set; }
        public string bullets { get; set; }
        public string short_description { get; set; }
        public string long_description_2 { get; set; }
        public string long_description_3 { get; set; }
        public string long_description_4 { get; set; }
        public string long_description_5 { get; set; }
        public string height { get; set; }
        public string length { get; set; }
        public string width { get; set; }
        public string size_unit { get; set; }
        public int weight { get; set; }
        public string weight_unit { get; set; }
        public int cost { get; set; }
        public double price { get; set; }
        public double retail { get; set; }
        public int minimum_quantity { get; set; }
        public int maximum_quantity { get; set; }
        public int is_spotlight_item { get; set; }
        public int quantity_on_hand { get; set; }
        public string keywords { get; set; }
        public int is_non_taxable { get; set; }
        public int is_shipped_individually { get; set; }
        public int is_hidden { get; set; }
        public int sort_order { get; set; }
        public string e_product_type { get; set; }
        public string e_product_url { get; set; }
        public string e_product_password { get; set; }
        public int e_product_verification_link_expiration { get; set; }
        public string e_product_email { get; set; }
        public int e_product_allow_multiple_deliveries { get; set; }
        public int warehouse_id { get; set; }
        public int call_for_shipping { get; set; }
        public int call_for_pricing { get; set; }
        public string rate_adjustment_type { get; set; }
        public string meta_description { get; set; }
        public string page_title { get; set; }
        public bool use_tabs { get; set; }
        public string related_name { get; set; }
        public bool override_theme_use_tabs { get; set; }
        public string long_description_tab_name_1 { get; set; }
        public string long_description_tab_name_2 { get; set; }
        public string long_description_tab_name_3 { get; set; }
        public string long_description_tab_name_4 { get; set; }
        public string long_description_tab_name_5 { get; set; }
        public string long_description_1 { get; set; }
        public bool is_non_shipping_item { get; set; }
        public object e_product_delivery_action { get; set; }
        public bool use_variant_inventory { get; set; }
        public bool is_featured_item { get; set; }
        public string long_description_external_url_1 { get; set; }
        public string long_description_external_url_2 { get; set; }
        public string long_description_external_url_3 { get; set; }
        public string long_description_external_url_4 { get; set; }
        public string long_description_external_url_5 { get; set; }
        public string bullets_external_url { get; set; }
        public bool custom_flag_1 { get; set; }
        public bool custom_flag_2 { get; set; }
        public bool custom_flag_3 { get; set; }
        public bool custom_flag_4 { get; set; }
        public bool custom_flag_5 { get; set; }
        public string url_rewrite { get; set; }
        public bool is_kit { get; set; }
        public bool is_child_product { get; set; }
        public bool is_non_inventory { get; set; }
        public bool is_discontinued { get; set; }
        public object eta_date { get; set; }
        public int quantity_on_order { get; set; }
        public object available_region_id { get; set; }
        public bool call_for_shipping_on_whole_order { get; set; }
        public bool break_out_shipping { get; set; }
        public string shipping_classification_code { get; set; }
        public bool exclude_parent_from_display { get; set; }
        public bool drop_ship { get; set; }
        public string no_price_mask { get; set; }
        public object starting_quantity { get; set; }
        public string tax_code { get; set; }
        public bool use_map_pricing { get; set; }
        public string last_item_number { get; set; }
        public bool has_visible_variants { get; set; }
        public object product_rating_dimension_group_override_id { get; set; }
        public int average_review_rating { get; set; }
        public int review_count { get; set; }
        public bool exclude_children_from_display { get; set; }
        public bool use_pricing_from_parent { get; set; }
        public object low_stock_warning_threshold { get; set; }
        public bool enable_low_stock_warning { get; set; }
        public bool do_not_discount { get; set; }
        public string head_tags { get; set; }
        public object handling_fee { get; set; }
        public string custom_upsell_url { get; set; }
        public string e_product_serial_number_file_path { get; set; }
        public bool hide_variant_surcharges { get; set; }
        public int quantity_increment { get; set; }
        public string gtin { get; set; }
        public string add_to_cart_message { get; set; }
        public bool is_subscription_product { get; set; }
        public object subscription_frequency { get; set; }
        public string subscription_frequency_type { get; set; }
        public string e_product_generic_username { get; set; }
        public string e_product_generic_password { get; set; }
        public object shipping_override { get; set; }
        public object insurance_cost { get; set; }
        public bool exclude_from_commissions { get; set; }
        public int days_until_reorder_allowed { get; set; }
        public bool force_separate_order { get; set; }
        public bool approval_required { get; set; }
        public object in_stock_notification_email_template_id { get; set; }
        public bool inelligible_for_purchase_by_points { get; set; }
        public bool earns_points { get; set; }
        public object additional_points_earned { get; set; }
        public string allowed_variable_subscription_types { get; set; }
        public object profile_id { get; set; }
        public bool is_default_child { get; set; }
        public bool bind_quantity_to_parent { get; set; }
        public bool is_required { get; set; }

    }
}
