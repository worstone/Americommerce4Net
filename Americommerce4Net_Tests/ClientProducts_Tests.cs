using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Americommerce4Net;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientProducts_Tests
    {
        [Test]
        public void ClientProducts_Get_Product_By_Id_Test() {
            int id = 1;
            var client = new ClientCatalog();
            var response = client.Products.Get(id);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            if (response.Data != null) {
                Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
                Assert.AreEqual(id, product.id);
            }
        }

        [Test]
        public void ClientProducts_Get_First_100_Products_Test() {

            var items = new List<Americommerce4Net.Models.Product>();

            var client = new ClientCatalog();
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .Page(1)
                .Count(100);

            var response = client.Products.Get(filter);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            if (response.Data != null) {
                foreach (var item in response.Data[client.Products.ResourceName]) {
                    items.Add(item.ToObject<Americommerce4Net.Models.Product>());
                }

                Assert.Greater(items.Count, 0);

                int total_count = (int)response.Data["total_count"].Value;

                Assert.Greater(total_count, 0);
            }
        }
    }
}
