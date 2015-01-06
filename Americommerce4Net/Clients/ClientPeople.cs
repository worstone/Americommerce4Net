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
    public class ClientPeople
    {

        IRestEngine _RestEngine;

        public ClientPeople() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientPeople(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientPeople(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }


        private ClientCustomer _Customers;
        public ClientCustomer Customers {
            get {
                if (_Customers == null) {
                    _Customers = new ClientCustomer(_RestEngine);
                }
                return _Customers;
            }
        }

        private ClientAddresses _Addresses;
        public ClientAddresses Addresses {
            get {
                if (_Addresses == null) {
                    _Addresses = new ClientAddresses(_RestEngine);
                }
                return _Addresses;
            }
        }

        private ClientCustomerPaymentMethods _CustomerPaymentMethods;
        public ClientCustomerPaymentMethods CustomerPaymentMethods {
            get {
                if (_CustomerPaymentMethods == null) {
                    _CustomerPaymentMethods = new ClientCustomerPaymentMethods(_RestEngine);
                }
                return _CustomerPaymentMethods;
            }
        }

        private ClientCustomerTypes _CustomerTypes;
        public ClientCustomerTypes CustomerTypes {
            get {
                if (_CustomerTypes == null) {
                    _CustomerTypes = new ClientCustomerTypes(_RestEngine);
                }
                return _CustomerTypes;
            }
        }

        private ClientProfiles _Profiles;
        public ClientProfiles Profiles {
            get {
                if (_Profiles == null) {
                    _Profiles = new ClientProfiles(_RestEngine);
                }
                return _Profiles;
            }
        }

        private ClientUsers _Users;
        public ClientUsers Users {
            get {
                if (_Users == null) {
                    _Users = new ClientUsers(_RestEngine);
                }
                return _Users;
            }
        }
    }
}
