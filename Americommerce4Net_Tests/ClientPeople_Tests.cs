using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Americommerce4Net;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class ClientPeople_Tests
    {
        [Test]
        public void Test() {
            var client = new ClientPeople();
            var response = client.Customers.Get(1);
            
        }
    }
}
