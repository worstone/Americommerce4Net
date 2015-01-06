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
    public class Email_Template : IResource
    {
        public int id { get; set; }
        public string type { get; set; }
        public string body { get; set; }
        public string subject { get; set; }
        public string from_name { get; set; }
        public string from_email { get; set; }
        public bool is_enabled { get; set; }
        public string admin_alert_header { get; set; }
        public string admin_alert_subject { get; set; }
        public bool is_admin_alert_enabled { get; set; }
        public string email_format { get; set; }
    }
}
