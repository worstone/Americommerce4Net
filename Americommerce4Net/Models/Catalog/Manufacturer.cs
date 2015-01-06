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

namespace Americommerce4Net.Models
{
    public class Manufacturer : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool is_hidden { get; set; }
        public int? sort_order { get; set; }
        public string manufacturer_logo_url { get; set; }
        public string page_title { get; set; }
        public string keywords { get; set; }
        public string meta_description { get; set; }
        public string url_rewrite { get; set; }
        public string head_tags { get; set; }
    }
}