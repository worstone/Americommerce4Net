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
    public class ClientSystem
    {

        IRestEngine _RestEngine;

        public ClientSystem() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientSystem(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientSystem(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }

        private ClientSessions _Sessions;
        public ClientSessions Sessions {
            get {
                if (_Sessions == null) {
                    _Sessions = new ClientSessions(_RestEngine);
                }
                return _Sessions;
            }
        }

        private ClientStores _Stores;
        public ClientStores Stores {
            get {
                if (_Stores == null) {
                    _Stores = new ClientStores(_RestEngine);
                }
                return _Stores;
            }
        }
    }
}
