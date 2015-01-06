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
    public class Page : BaseAudit, IResource
    {
        public int id { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public bool is_hidden { get; set; }
        public int store_id { get; set; }
        public string external_url { get; set; }
        public bool is_content_only { get; set; }
        public string url_rewrite { get; set; }
        public bool is_secure { get; set; }
        public bool is_login_required { get; set; }
    }
}