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
    public class Client
    {

        IRestEngine _RestEngine;

        public Client() {
            _RestEngine = new RestEngine(new Configuration());
        }
        public Client(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }

        private ClientPeople _People;
        public ClientPeople People {
            get {
                if (_People == null) {
                    _People = new ClientPeople(_RestEngine);
                }
                return _People;
            }
        }

        private ClientOrderProc _OrderProc;
        public ClientOrderProc OrderProc {
            get {
                if (_OrderProc == null) {
                    _OrderProc = new ClientOrderProc(_RestEngine);
                }
                return _OrderProc;
            }
        }

        private ClientCatalog _Catalog;
        public ClientCatalog Catalog {
            get {
                if (_Catalog == null) {
                    _Catalog = new ClientCatalog(_RestEngine);
                }
                return _Catalog;
            }
        }

        private ClientContent _Content;
        public ClientContent Content {
            get {
                if (_Content == null) {
                    _Content = new ClientContent(_RestEngine);
                }
                return _Content;
            }
        }

        private ClientMarketing _Marketing;
        public ClientMarketing Marketing {
            get {
                if (_Marketing == null) {
                    _Marketing = new ClientMarketing(_RestEngine);
                }
                return _Marketing;
            }
        }

        private ClientTools _Tools;
        public ClientTools Tools {
            get {
                if (_Tools == null) {
                    _Tools = new ClientTools(_RestEngine);
                }
                return _Tools;
            }
        }

        private ClientSettings _Settings;
        public ClientSettings Settings {
            get {
                if (_Settings == null) {
                    _Settings = new ClientSettings(_RestEngine);
                }
                return _Settings;
            }
        }

        private ClientSystem _System;
        public ClientSystem System {
            get {
                if (_System == null) {
                    _System = new ClientSystem(_RestEngine);
                }
                return _System;
            }
        }
    }
}
