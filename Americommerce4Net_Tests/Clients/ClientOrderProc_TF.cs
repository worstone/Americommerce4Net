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

using Americommerce4Net;
using NUnit.Framework;
using System.Collections.Generic;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientOrderProc_TF : Base_TF
    {
        [Test]
        public void ClientOrderProc_Get_Order_By_Id_Test() {
            var client = new ClientOrderProc();
            var response = client.Orders.Get(ORDERS_ID);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            Americommerce4Net.Models.Order order = response.Data.ToObject<Americommerce4Net.Models.Order>();
            Assert.AreEqual(ORDERS_ID, order.id);
        }

        [Test]
        public void ClientOrderProc_Get_First_100_Orders_Test() {

            var items = new List<Americommerce4Net.Models.Order>();

            var client = new ClientOrderProc();
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .Page(1)
                .Count(100);

            var response = client.Orders.Get(filter);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            foreach (var item in response.Data[client.Orders.ResourceName]) {
                items.Add(item.ToObject<Americommerce4Net.Models.Order>());
            }
            Assert.Greater(items.Count, 0);
            int total_count = (int)response.Data["total_count"].Value;
            Assert.Greater(total_count, 0);
        }
    }
}
