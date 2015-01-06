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
    public class User : BaseAudit, IResource
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string last_login_attempt_at { get; set; }
        public string last_login_at { get; set; }
        public object user_role_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_extension { get; set; }
        public string alternate_phone { get; set; }
        public string fax { get; set; }
        public int profile_id { get; set; }
    }
}