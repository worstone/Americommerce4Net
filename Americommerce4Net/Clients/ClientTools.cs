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
    public class ClientTools
    {

        IRestEngine _RestEngine;

        public ClientTools() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientTools(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientTools(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }

        private ClientCustomFields _CustomFields;
        public ClientCustomFields CustomFields {
            get {
                if (_CustomFields == null) {
                    _CustomFields = new ClientCustomFields(_RestEngine);
                }
                return _CustomFields;
            }
        }
    }
}