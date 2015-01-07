Americommerce4Net
=================

.Net REST client for the AmeriCommerce v1 API

Americommerce4Net Dependencies
------------
- .NET Framwork 4 - http://msdn.microsoft.com/en-US/vstudio/aa496123.aspx
- log4net - http://logging.apache.org/log4net/
- Newtonsoft.Json - http://james.newtonking.com/projects/json-net.aspx
- RestSharp - http://restsharp.org/

Americommerce4Net_Tests Dependencies
------------
- Above Dependencies 
- NUnit - http://nunit.org/

AmeriCommerce v1 API Documentation
------------
- https://github.com/americommerce/ac-rest-api


Namespace
---------
```csharp
using Americommerce4Net;

```
Connection
------------
To connect to the API, you need the following credentials:

- Secure URL pointing to a Americommerce store (https://--yourstore--/api/v1)
- Api Access Token

Basic Configuration
-------------

```csharp
var configuration = new Configuration(
								"https://--yourstore--/api/v1",
								"--your api access token--"
								) ;
            
var Client = new Client(configuration);
```

or

```csharp
var Client = new Client();  // This will read AppSettings from the App.config
```

Clients
-------------

Main Client includes all clients grouped by functionality 

* Client
	* Catalog
	* Content
	* Marketing
	* OrderProc
	* People
	* Settings
	* System
	* Tools

Each of the functionality grouped clients can be used independently, depending on your needs

* ClientCatalog
* ClientContent
* ClientMarketing
* ClientOrderProc
* ClientPeople
* ClientSettings
* ClientSystem
* ClientTools

All clients respond with IClientResponse interface

```csharp
public interface IClientResponse<T>
    {
        T Data { get; set; }
        global::RestSharp.IRestResponse RestResponse { get; set; }
    }
```
and Data is dynamic {Newtonsoft.Json.Linq.JObject}
```csharp
Newtonsoft.Json.Linq.JObject.ToObject<T>()
```
Can use the JObject.ToObject method to deserialized to an object.

Query Syntax / Filters
-------------
The filters use fluent interface such as 
```csharp
var client = new ClientCatalog();
var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual())
                .ExpandNested("custom_fields", "categories", "pricing", "pictures");
var response = client.Products.Get(filter);
```
or
```csharp
var client = new ClientOrderProc();
var filter = new FilterList()
	.Query(new FilterQuery()
	.FieldName("id")
	.FieldValue("0")
	.Compare_GreaterThan())
	.Page(1)
	.Count(100);

var response = client.Orders.Get(filter);
```

Models
-------------
Based on the AmeriCommerce v1 API Documentation, Resource classes are here. Some classes need to be tested a bit more

Reading Store Data
-------------
```csharp
int id = 1;
var client = new ClientCatalog();
var response = client.Products.Get(id);
if (response.Data != null) {
	Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
	Assert.AreEqual(id, product.id);
}
```
Updating Store Data
-------------
```csharp
int id = 18;
var obj = new {
	bullets = "<p>Test</p>", 
	item_name = "Natalie Dining Table Set"
	};

var client = new ClientCatalog();
var response = client.Products.Update(id, obj);
if (response.Data != null) {
	Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
	Assert.AreEqual(id, product.id);
	Assert.AreEqual("<p>Test</p>", product.bullets);
	Assert.AreEqual("Natalie Dining Table Set", product.item_name);
}
```

Create Store Data
-------------
```csharp
var obj = new {
		item_number = "123456789",
		item_name = "TEST 123456789 Product", 
		price = 99.00, 
		cost = 50.00, 
		retail = 150.00,
		weight = 25.00,
		long_description_1 = "<p>TEST 123456789 Product Long Description</p>"
		};

var client = new ClientCatalog();
var response = client.Products.Create(obj);
if (response.Data != null) {
	Americommerce4Net.Models.Product product = response.Data.ToObject<Americommerce4Net.Models.Product>();
	Assert.AreEqual("123456789", product.item_number);
	Assert.AreEqual("TEST 123456789 Product", product.item_name);
}		
```

Delete Store Data
-------------
Note: Configuration.AllowDeletions must be true

```csharp
int id = 18;
var client = new ClientCatalog();
var response = client.Products.Delete(id);
Assert.AreEqual(true, response.Data);
```

Repositories
-------------
There are a few Repositories that have been put together to abstract away the clients

```csharp
var repo = new RepoProduct();
var response = repo.GetAll();
List<Product> products;
if(response.ErrorException == null){
	products = response.Data;
}
```
The Repositories also has paging & throttling logic built in.

Note:The Repositories require AppSettings in the App.config to be set.
		
License
-------------

Copyright 2015 Ken Worst - R.C. Worst & Company Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. 

