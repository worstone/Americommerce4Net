Americommerce4Net
=================

.Net REST client for the AmeriCommerce v1 API

Requirements
------------

- .NET Framwork 4 - http://msdn.microsoft.com/en-US/vstudio/aa496123.aspx
- log4net - http://logging.apache.org/log4net/
- Newtonsoft.Json - http://james.newtonking.com/projects/json-net.aspx
- NUnit - http://nunit.org/
- RestSharp - http://restsharp.org/

AmeriCommerce v1 API Documentation
------------
- https://github.com/americommerce/ac-rest-api

Connection
------------
To connect to the API, you need the following credentials:

- Secure URL pointing to a Americommerce store (https://--yourstore--/api/v1)
- Api Access Token

Namespace
---------
```
using Americommerce4Net;

```

Basic Configuration
-------------

```
var configuration = new Configuration(
								"https://--yourstore--/api/v1",
								"--your api access token--"
								) ;
            
var Client = new Client(configuration);
```

or

```
var Client = new Client();  // This will read AppSettings from the App.config
```

Clients
-------------

Main Client includes all client grouped by functionality 

* Client
	* Catalog
	* Content
	* Marketing
	* OrderProc
	* People
	* Settings
	* System
	* Tools

Each of the functionality grouped clients can be used independently 

* ClientCatalog
* ClientContent
* ClientMarketing
* ClientOrderProc
* ClientPeople
* ClientSettings
* ClientSystem
* ClientTools

All clients respond with IClientResponse interface

```
public interface IClientResponse<T>
    {
        T Data { get; set; }
        global::RestSharp.IRestResponse RestResponse { get; set; }
    }
```
and Data is dynamic {Newtonsoft.Json.Linq.JObject}
```
Newtonsoft.Json.Linq.JObject.ToObject<T>()
```
Can be used to deserialized to and object.

Query Syntax / Filters
-------------
The filters fluent api such as 
```
var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual())
                .ExpandNested("custom_fields", "categories", "pricing", "pictures");
var response = Client.Get(id, filter);
```
Repositories
-------------
There are a few Repositories that have been put together to abstract away the clients


Models
-------------
Based on the AmeriCommerce v1 API Documentation, Resource classes are here.

Accessing Store Data
-------------

Examples coming soon

Updating Store Data
-------------
Examples coming soon

Create Store Data
-------------
Examples coming soon		

Delete Store Data
-------------
Note: Configuration.AllowDeletions must be true

Examples coming soon
		
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

