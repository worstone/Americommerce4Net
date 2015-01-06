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

namespace Americommerce4Net
{
    public class FilterQuery
    {
        internal string _ComparisonOperator { get; set; }
        internal string _LogicOperator { get; set; }
        internal string _FieldName { get; set; }
        internal string _FieldValue { get; set; }

        public FilterQuery() {
            _ComparisonOperator = "eq";
            _LogicOperator = "AND";
        }

        public FilterQuery FieldName(string filename) {
            _FieldName = filename;
            return this;
        }
        public FilterQuery FieldValue(string value) {
            _FieldValue = value;
            return this;
        }

        public FilterQuery Compare_EqualTo() {
            _ComparisonOperator = "eq";
            return this;
        }
        public FilterQuery Compare_NotEqual() {
            _ComparisonOperator = "not";
            return this;
        }
        public FilterQuery Compare_Contains() {
            _ComparisonOperator = "like";
            return this;
        }
        public FilterQuery Compare_GreaterThan() {
            _ComparisonOperator = "gt";
            return this;
        }
        public FilterQuery Compare_GreaterThanOrEqual() {
            _ComparisonOperator = "gte";
            return this;
        }
        public FilterQuery Comparison_LessThan () {
            _ComparisonOperator = "lt";
            return this;
        }
        public FilterQuery Comparison_LessThanOrEqual() {
            _ComparisonOperator = "lte";
            return this;
        }

        public FilterQuery Logic_And() {
            _LogicOperator = "AND";
            return this;
        }

        public FilterQuery Logic_Or() {
            _LogicOperator = "OR";
            return this;
        }
    }
}
