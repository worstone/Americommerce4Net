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
    public class Link_Child_Link : BaseAudit, IResource
    {
        public int id { get; set; }
        public string url { get; set; }
        public string text { get; set; }
        public object sort_order { get; set; }
        public int store_id { get; set; }
        public bool is_hidden { get; set; }
        public object named_link { get; set; }
        public int page_id { get; set; }
        public int category_id { get; set; }
        public bool is_dynamic_menu_root { get; set; }
        public int dynamic_menu_levels { get; set; }
        public string link_type { get; set; }
        public int parent_link_id { get; set; }
        public bool is_hidden_in_navigation_only { get; set; }
        public bool opens_in_new_window { get; set; }
        public bool is_home_page { get; set; }
        public int product_id { get; set; }
        public int blog_id { get; set; }
        public int blog_category_id { get; set; }
    }
}
