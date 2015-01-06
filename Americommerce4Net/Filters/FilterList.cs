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
    public class FilterList : BaseFilter
    {
        int? _Page;
        int? _Count;
        string[] _ExpandNested;
        string[] _Sort;
        string[] _Fields;
        FilterQuery[] _Query;

        public FilterList Page(int value) {
            _Page = value;
            return this;
        }
        public FilterList Count(int value) {
            _Count = value;
            return this;
        }
        public FilterList ExpandNested(params string[] list) {
            _ExpandNested = list;
            return this;
        }

        public FilterList Sort(params string[] list) {
            _Sort = list;
            return this;
        }

        public FilterList Fields(params string[] list) {
            _Fields = list;
            return this;
        }

        public FilterList Query(params FilterQuery[] list) {
            _Query = list;
            return this;
        }

        public override void AddFilter(IRestRequest request) {
            PageBuilder(request, _Page);
            CountBuilder(request, _Count);
            ExpandBuilder(request, _ExpandNested);
            SortBuilder(request, _Sort);
            FieldsBuilder(request, _Fields);
            QueryBuilder(request, _Query);
        }
    }
}
