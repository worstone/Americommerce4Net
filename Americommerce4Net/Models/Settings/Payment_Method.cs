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
    public class Payment_Method : BaseAudit, IResource
    {
        public int id { get; set; }
        public string payment_type { get; set; }
        public int cost_modifier { get; set; }
        public string cost_modifier_type { get; set; }
        public int sort_order { get; set; }
        public bool is_hidden { get; set; }
        public string description { get; set; }
        public string confirmation_message { get; set; }
        public string declined_message { get; set; }
        public bool is_gateway { get; set; }
        public string gateway_name { get; set; }
        public string name { get; set; }
    }
}
