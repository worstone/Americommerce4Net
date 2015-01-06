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

using System.Collections.Generic;

namespace Americommerce4Net.Models
{
    public class Region : BaseAudit, IResource
    {
        public int id { get; set; }
        public List<object> postal_codes { get; set; }
        public string name { get; set; }
        public List<object> states { get; set; }
        public List<string> countries { get; set; }
        public string markup_type { get; set; }
        public int markup_amount { get; set; }
        public int sort_order { get; set; }
        public string region_type { get; set; }
        public object postal_code_country { get; set; }
        public bool is_shipping_region { get; set; }
        public bool is_tax_region { get; set; }
    }
}
