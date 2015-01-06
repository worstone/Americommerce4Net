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

using RestSharp;
using Americommerce4Net.Filters;

namespace Americommerce4Net
{
    public class FilterSingle : BaseFilter
    {
        string[] _ExpandNested;
        string[] _Fields;

        public FilterSingle ExpandNested(params string[] list) {
            _ExpandNested = list;
            return this;
        }
        public FilterSingle Fields(params string[] list) {
            _Fields = list;
            return this;
        }

        public override void AddFilter(IRestRequest request) {
            ExpandBuilder(request, _ExpandNested);
            FieldsBuilder(request, _Fields);
        }
    }
}
