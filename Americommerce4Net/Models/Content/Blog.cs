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
    public class Blog : BaseAudit, IResource
    {
        public int id { get; set; }
        public int store_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tag_line { get; set; }
        public string url_slug { get; set; }
        public string meta_description { get; set; }
        public string meta_keywords { get; set; }
        public string copyright { get; set; }
        public string image_url { get; set; }
        public string language { get; set; }
        public int max_feed_elements { get; set; }
        public string syndication_type { get; set; }
        public bool is_rss_feed_enabled { get; set; }
        public bool is_atom_feed_enabled { get; set; }
        public int max_chars_short_feed { get; set; }
        public int max_chars_summary { get; set; }
        public bool is_commenting_enabled { get; set; }
        public bool is_comment_moderation_enabled { get; set; }
        public string default_post_image { get; set; }
        public string default_teaser_image { get; set; }
        public object new_post_notification_email_template_id { get; set; }
        public int new_comment_notification_email_template_id { get; set; }
        public bool notify_commenters_on_new_comments { get; set; }
        public int new_comment_admin_notification_email_template_id { get; set; }
    }
}
