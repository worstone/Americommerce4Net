using System.Collections.Generic;
using NUnit.Framework;
using Americommerce4Net;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientPeople_TF
    {
        [Test]
        public void ClientPeople_Get_Customer_By_Id_Test() {
            int id = 1;
            var client = new ClientPeople();
            var response = client.Customers.Get(id);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            Americommerce4Net.Models.Customer customer = response.Data.ToObject<Americommerce4Net.Models.Customer>();
            Assert.AreEqual(id, customer.id);
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
