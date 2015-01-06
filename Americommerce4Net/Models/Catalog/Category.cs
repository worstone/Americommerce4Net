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
    public class Category : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_description { get; set; }
        public int sort_order { get; set; }
        public bool is_hidden { get; set; }
        public int parent_category_id { get; set; }
        public int max_quantity { get; set; }
        public string category_thumbnail { get; set; }
        public string page_title { get; set; }
        public string keywords { get; set; }
        public string meta_description { get; set; }
        public string category_image { get; set; }
        public string external_content_url { get; set; }
        public bool is_category_content_displayed { get; set; }
        public bool are_subcategory_products_displayed { get; set; }
        public string url_rewrite { get; set; }
        public string default_product_picture { get; set; }
        public string alternate_thumbnail { get; set; }
        public string head_tags { get; set; }
    }
}