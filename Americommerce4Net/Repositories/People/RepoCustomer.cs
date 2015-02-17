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
    public class RepoCustomer : BaseRepoReadWrite<Customer>
    {
        readonly static IClientReadWrite _Client = new ClientPeople().Customers;

        public RepoCustomer()
            : base(_Client, "customers") {
        }

        public IRepoResponse<List<Customer>> GetByCustomerNumber(string customer_number) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("customer_number")
                .FieldValue(customer_number)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }

        public IRepoResponse<List<Customer>> GetByCustomerNumber(string customer_number, params string[] expandNested) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("customer_number")
                .FieldValue(customer_number)
                .Compare_EqualTo())
                .ExpandNested(expandNested);

            return base.RecordPaging(filter);
        }
    }
}