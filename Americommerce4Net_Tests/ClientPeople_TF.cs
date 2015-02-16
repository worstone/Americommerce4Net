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
using NUnit.Framework;
using Americommerce4Net;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientPeople_TF : Base_TF
    {
        [Test]
        public void ClientPeople_Get_Customer_By_Id_Test() {
            var client = new ClientPeople();
            var response = client.Customers.Get(CUSTOMERS_ID);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            Americommerce4Net.Models.Customer customer = response.Data.ToObject<Americommerce4Net.Models.Customer>();
            Assert.AreEqual(CUSTOMERS_ID, customer.id);
        }

        [Test]
        public void ClientPeople_Get_First_100_Customers_Test() {

            var items = new List<Americommerce4Net.Models.Customer>();

            var client = new ClientPeople();
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .Page(1)
                .Count(100);

            var response = client.Customers.Get(filter);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            foreach (var item in response.Data[client.Customers.ResourceName]) {
                items.Add(item.ToObject<Americommerce4Net.Models.Customer>());
            }
            Assert.Greater(items.Count,0);
            int total_count = (int)response.Data["total_count"].Value;
            Assert.Greater(total_count, 0);
        }
    }
}
