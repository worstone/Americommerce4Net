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
    public class Blog_Post : BaseAudit, IResource
    {
        public int id { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public string published_at { get; set; }
        public string teaser_title { get; set; }
        public string teaser_description { get; set; }
        public string post_image_url { get; set; }
        public string teaser_image_url { get; set; }
        public int author_profile_id { get; set; }
        public bool are_comments_enabled { get; set; }
        public bool is_featured { get; set; }
        public bool is_stickied { get; set; }
        public bool are_comments_locked { get; set; }
        public int view_count { get; set; }
    }
}