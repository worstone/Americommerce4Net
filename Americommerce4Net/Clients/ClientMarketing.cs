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
    public class ClientMarketing
    {

        IRestEngine _RestEngine;

        public ClientMarketing() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientMarketing(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientMarketing(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }

        private ClientAdcodes _Adcodes;
        public ClientAdcodes Adcodes {
            get {
                if (_Adcodes == null) {
                    _Adcodes = new ClientAdcodes(_RestEngine);
                }
                return _Adcodes;
            }
        }

        private ClientAffiliates _Affiliates;
        public ClientAffiliates Affiliates {
            get {
                if (_Affiliates == null) {
                    _Affiliates = new ClientAffiliates(_RestEngine);
                }
                return _Affiliates;
            }
        }

        private ClientDrips _Drips;
        public ClientDrips Drips {
            get {
                if (_Drips == null) {
                    _Drips = new ClientDrips(_RestEngine);
                }
                return _Drips;
            }
        }

        private ClientDiscountMethods _DiscountMethods;
        public ClientDiscountMethods DiscountMethods {
            get {
                if (_DiscountMethods == null) {
                    _DiscountMethods = new ClientDiscountMethods(_RestEngine);
                }
                return _DiscountMethods;
            }
        }

        private ClientDiscountRules _DiscountRules;
        public ClientDiscountRules DiscountRules {
            get {
                if (_DiscountRules == null) {
                    _DiscountRules = new ClientDiscountRules(_RestEngine);
                }
                return _DiscountRules;
            }
        }

        private ClientCouponCodes _CouponCodes;
        public ClientCouponCodes CouponCodes {
            get {
                if (_CouponCodes == null) {
                    _CouponCodes = new ClientCouponCodes(_RestEngine);
                }
                return _CouponCodes;
            }
        }

        private ClientGiftCertificates _GiftCertificates;
        public ClientGiftCertificates GiftCertificates {
            get {
                if (_GiftCertificates == null) {
                    _GiftCertificates = new ClientGiftCertificates(_RestEngine);
                }
                return _GiftCertificates;
            }
        }

        private ClientGiftCertificateTransactions _GiftCertificateTransactions;
        public ClientGiftCertificateTransactions GiftCertificateTransactions {
            get {
                if (_GiftCertificateTransactions == null) {
                    _GiftCertificateTransactions = new ClientGiftCertificateTransactions(_RestEngine);
                }
                return _GiftCertificateTransactions;
            }
        }

        private ClientMailingLists _MailingLists;
        public ClientMailingLists MailingLists {
            get {
                if (_MailingLists == null) {
                    _MailingLists = new ClientMailingLists(_RestEngine);
                }
                return _MailingLists;
            }
        }

        private ClientEmailTemplates _EmailTemplates;
        public ClientEmailTemplates EmailTemplates {
            get {
                if (_EmailTemplates == null) {
                    _EmailTemplates = new ClientEmailTemplates(_RestEngine);
                }
                return _EmailTemplates;
            }
        }
    }
}
