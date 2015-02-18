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

using System;
using System.Configuration;

namespace Americommerce4Net_Tests
{
    public class Base_TF
    {
        protected int PRODUCTS_ID = int.Parse(ConfigurationManager.AppSettings["Americommerce4Net_Tests_PRODUCTS_ID"]);
        protected string PRODUCTS_ITEM_NUMBER = ConfigurationManager.AppSettings["Americommerce4Net_Tests_PRODUCTS_ITEM_NUMBER"];
        protected int CUSTOMERS_ID = int.Parse(ConfigurationManager.AppSettings["Americommerce4Net_Tests_CUSTOMERS_ID"]);
        protected int ORDERS_ID = int.Parse(ConfigurationManager.AppSettings["Americommerce4Net_Tests_ORDERS_ID"]);
    }
}
