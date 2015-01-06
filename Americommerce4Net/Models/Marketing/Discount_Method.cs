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
    public class Discount_Method : BaseAudit, IResource
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_enabled { get; set; }
        public bool is_strict { get; set; }
        public string modifier_operation { get; set; }
        public string modifier_amount { get; set; }
        public string modifier_type { get; set; }
        public string modifier_target { get; set; }
        public bool use_once { get; set; }
        public bool expires { get; set; }
        public string expires_at { get; set; }
        public string starts_at { get; set; }
        public object remaining_uses { get; set; }
        public string notes { get; set; }
        public bool is_free_shipping_discount { get; set; }
    }
}
