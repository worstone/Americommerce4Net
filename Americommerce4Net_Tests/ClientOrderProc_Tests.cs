using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Americommerce4Net;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientOrderProc_Tests
    {
        [Test]
        public void ClientOrderProc_Get_Order_By_Id_Test() {
            int id = 100002;
            var client = new ClientOrderProc();
            var response = client.Orders.Get(id);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            if (response.Data != null) {
                Americommerce4Net.Models.Order order = response.Data.ToObject<Americommerce4Net.Models.Order>();
                Assert.AreEqual(id, order.id);
            }
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
            if (response.Data != null) {
                foreach (var item in response.Data[client.Orders.ResourceName]) {
                    items.Add(item.ToObject<Americommerce4Net.Models.Order>());
                }

                Assert.Greater(items.Count, 0);

                int total_count = (int)response.Data["total_count"].Value;

                Assert.Greater(total_count, 0);
            }
        }
    }
}
