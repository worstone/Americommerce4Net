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

using Americommerce4Net.Clients;

namespace Americommerce4Net
{
    public class ClientSettings
    {

        IRestEngine _RestEngine;

        public ClientSettings() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientSettings(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientSettings(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }

        private ClientUrlRedirects _UrlRedirects;
        public ClientUrlRedirects UrlRedirects {
            get {
                if (_UrlRedirects == null) {
                    _UrlRedirects = new ClientUrlRedirects(_RestEngine);
                }
                return _UrlRedirects;
            }
        }

        private ClientTaxRates _TaxRates;
        public ClientTaxRates TaxRates {
            get {
                if (_TaxRates == null) {
                    _TaxRates = new ClientTaxRates(_RestEngine);
                }
                return _TaxRates;
            }
        }

        private ClientPaymentMethods _PaymentMethods;
        public ClientPaymentMethods PaymentMethods {
            get {
                if (_PaymentMethods == null) {
                    _PaymentMethods = new ClientPaymentMethods(_RestEngine);
                }
                return _PaymentMethods;
            }
        }

        private ClientRegions _Regions;
        public ClientRegions Regions {
            get {
                if (_Regions == null) {
                    _Regions = new ClientRegions(_RestEngine);
                }
                return _Regions;
            }
        }

        private ClientShippingProviders _ShippingProviders;
        public ClientShippingProviders ShippingProviders {
            get {
                if (_ShippingProviders == null) {
                    _ShippingProviders = new ClientShippingProviders(_RestEngine);
                }
                return _ShippingProviders;
            }
        }

        private ClientCustomShippingMethods _CustomShippingMethods;
        public ClientCustomShippingMethods CustomShippingMethods {
            get {
                if (_CustomShippingMethods == null) {
                    _CustomShippingMethods = new ClientCustomShippingMethods(_RestEngine);
                }
                return _CustomShippingMethods;
            }
        }

        private ClientWarehouses _Warehouses;
        public ClientWarehouses Warehouses {
            get {
                if (_Warehouses == null) {
                    _Warehouses = new ClientWarehouses(_RestEngine);
                }
                return _Warehouses;
            }
        }
    }
}
