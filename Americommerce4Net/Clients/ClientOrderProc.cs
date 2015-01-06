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
    public class ClientOrderProc
    {

        IRestEngine _RestEngine;

        public ClientOrderProc() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientOrderProc(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientOrderProc(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }


        private ClientCarts _Carts;
        public ClientCarts Carts {
            get {
                if (_Carts == null) {
                    _Carts = new ClientCarts(_RestEngine);
                }
                return _Carts;
            }
        }

        private ClientCartItems _CartItems;
        public ClientCartItems CartItems {
            get {
                if (_CartItems == null) {
                    _CartItems = new ClientCartItems(_RestEngine);
                }
                return _CartItems;
            }
        }

        private ClientOrders _Orders;
        public ClientOrders Orders {
            get {
                if (_Orders == null) {
                    _Orders = new ClientOrders(_RestEngine);
                }
                return _Orders;
            }
        }

        private ClientOrderItems _OrderItems;
        public ClientOrderItems OrderItems {
            get {
                if (_OrderItems == null) {
                    _OrderItems = new ClientOrderItems(_RestEngine);
                }
                return _OrderItems;
            }
        }

        private ClientOrderPayments _OrderPayments;
        public ClientOrderPayments OrderPayments {
            get {
                if (_OrderPayments == null) {
                    _OrderPayments = new ClientOrderPayments(_RestEngine);
                }
                return _OrderPayments;
            }
        }

        private ClientOrderShipments _OrderShipments;
        public ClientOrderShipments OrderShipments {
            get {
                if (_OrderShipments == null) {
                    _OrderShipments = new ClientOrderShipments(_RestEngine);
                }
                return _OrderShipments;
            }
        }

        private ClientOrderAddresses _OrderAddresses;
        public ClientOrderAddresses OrderAddresses {
            get {
                if (_OrderAddresses == null) {
                    _OrderAddresses = new ClientOrderAddresses(_RestEngine);
                }
                return _OrderAddresses;
            }
        }

        private ClientQuotes _Quotes;
        public ClientQuotes Quotes {
            get {
                if (_Quotes == null) {
                    _Quotes = new ClientQuotes(_RestEngine);
                }
                return _Quotes;
            }
        }

        private ClientSubscriptions _Subscriptions;
        public ClientSubscriptions Subscriptions {
            get {
                if (_Subscriptions == null) {
                    _Subscriptions = new ClientSubscriptions(_RestEngine);
                }
                return _Subscriptions;
            }
        }

        private ClientCreditCards _CreditCards;
        public ClientCreditCards CreditCards {
            get {
                if (_CreditCards == null) {
                    _CreditCards = new ClientCreditCards(_RestEngine);
                }
                return _CreditCards;
            }
        }

        private ClientOrderStatuses _OrderStatuses;
        public ClientOrderStatuses OrderStatuses {
            get {
                if (_OrderStatuses == null) {
                    _OrderStatuses = new ClientOrderStatuses(_RestEngine);
                }
                return _OrderStatuses;
            }
        }
    }
}