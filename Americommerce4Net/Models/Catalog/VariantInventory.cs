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
    public class VariantInventory : BaseAudit, IResource
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int? inventory { get; set; }
        public string item_number { get; set; }
        public string manufacturer_item_number { get; set; }
        public int? weight { get; set; }
        public int? product_status_id { get; set; }
        public int? low_stock_warning_at { get; set; }
        public bool low_stock_warning_enabled { get; set; }
        public string gtin { get; set; }
    }
}
