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
    public class Product_Review : BaseAudit, IResource
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string review_pros { get; set; }
        public string review_cons { get; set; }
        public int overall_rating { get; set; }
        public object customer_id { get; set; }
        public object approved_by_user_id { get; set; }
        public object approved_at { get; set; }
        public string author_display_name { get; set; }
        public string author_email { get; set; }
        public string author_website { get; set; }
        public string author_location { get; set; }
        public string approval_status { get; set; }
        public int origin_store_id { get; set; }
    }
}
