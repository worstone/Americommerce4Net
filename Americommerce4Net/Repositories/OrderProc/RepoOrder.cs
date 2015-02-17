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

using System;
using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrder : BaseRepoReadWrite<Order>
    {

        readonly static IClientReadWrite _Client = new ClientOrderProc().Orders;

        public RepoOrder()
            : base(_Client, "orders") {
        }

        public IRepoResponse<List<Order>> GetByOrderNumber(string order_number) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("order_number")
                .FieldValue(order_number)
                .Compare_EqualTo());

            return base.RecordPaging(filter);
        }

        public IRepoResponse<List<Order>> GetByOrderNumber(string order_number, params string[] expandNested) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("order_number")
                .FieldValue(order_number)
                .Compare_EqualTo())
                .ExpandNested(expandNested);

            return base.RecordPaging(filter);
        }
    }
}