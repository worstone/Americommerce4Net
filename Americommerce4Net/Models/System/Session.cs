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
    public class Session : IResource
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int user_id { get; set; }
        public string first_hit_at { get; set; }
        public string last_hit_at { get; set; }
        public string ip_address { get; set; }
        public string host_name { get; set; }
        public int adcode_id { get; set; }
        public int hit_count { get; set; }
        public int visit_count { get; set; }
        public string page_last_visited { get; set; }
        public string referer { get; set; }
        public int is_abandoned { get; set; }
        public string user_agent { get; set; }
        public int cart_id { get; set; }
        public int wish_list_cart_id { get; set; }
    }
}