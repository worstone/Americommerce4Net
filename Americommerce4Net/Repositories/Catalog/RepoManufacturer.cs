#region License
//   Copyright 2015 Ken Worst - R.C. Worst & Company Inc.
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
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoManufacturer : BaseRepoReadWrite<Manufacturer>
    {
        readonly static IClientReadWrite _Client = new ClientCatalog().Manufacturers;

        public RepoManufacturer()
            : base(_Client, "manufacturers") {
        }
       
        public override IRepoResponse<List<Manufacturer>> GetAll() {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan());
            return base.GetAll(filter);
        }

        public IRepoResponse<List<Manufacturer>> GetAllStartingAtId(int id) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue(id.ToString())
                .Compare_GreaterThanOrEqual());
            return base.GetAll(filter);
        }

        public IRepoResponse<List<Manufacturer>> GetByManufacturerName(string manufacturerName) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("name")
                .FieldValue(manufacturerName)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }
    }
}
