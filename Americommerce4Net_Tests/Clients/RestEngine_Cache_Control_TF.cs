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
using System.Linq;
using RestSharp;

namespace Americommerce4Net_Tests
{
    [TestFixture]
    public class RestEngine_Cache_Control_TF : Base_TF
    {
        [Test]
        public void Test_For_No_Cache() {
            var client = new ClientCatalog();
            client.Products.CacheControl = CacheControl.NoCache;
            var response = client.Products.Get(PRODUCTS_ID);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
            Assert.AreEqual(PRODUCTS_ID, product.id);
            var request_head_cache_control = response.RestResponse.Request.Parameters.Where(x => x.Name == "Cache-Control").FirstOrDefault();
            Assert.NotNull(request_head_cache_control);
            Assert.AreEqual(ParameterType.HttpHeader, request_head_cache_control.Type);
            Assert.AreEqual("Cache-Control", request_head_cache_control.Name);
            Assert.AreEqual("no-cache", request_head_cache_control.Value.ToString());
        }

        [Test]
        public void Test_For_Has_Caching_On() {
            var client = new ClientCatalog();
            var response = client.Products.Get(PRODUCTS_ID);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.RestResponse.StatusCode);
            Assert.NotNull(response.Data);
            Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
            Assert.AreEqual(PRODUCTS_ID, product.id);
            var request_head_cache_control = response.RestResponse.Request.Parameters.Where(x => x.Name == "Cache-Control").FirstOrDefault();
            Assert.IsNull(request_head_cache_control);
        }
    }
}