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
using System.Text;

namespace Americommerce4Net.Filters
{
    public abstract class BaseFilter : IFilter
    {
        public abstract void AddFilter(IRestRequest request); 

        protected void PageBuilder(IRestRequest request, int? page) {
            if (page != null) {
                request.AddParameter("page", page, ParameterType.QueryString);
            }
        }

        protected void CountBuilder(IRestRequest request, int? count) {
            if (count != null) {
                request.AddParameter("count", count, ParameterType.QueryString);
            }
        }

        protected void ExpandBuilder(IRestRequest request, string[] expand) {
            if (expand != null && expand.Length > 0) {
                request.AddParameter("expand", string.Join(",", expand), ParameterType.QueryString);
            }
        }
        protected void SortBuilder(IRestRequest request, string[] sort) {
            if (sort != null && sort.Length > 0) {
                request.AddParameter("sort", string.Join(",", sort), ParameterType.QueryString);
            }
        }
        protected void FieldsBuilder(IRestRequest request, string[] fields) {
            if (fields != null && fields.Length > 0) {
                request.AddParameter("fields", string.Join(",", fields), ParameterType.QueryString);
            }
        }
        protected void IdsBuilder(IRestRequest request, int[] ids) {
            if (ids != null && ids.Length > 0) {
                request.AddParameter("ids", string.Join(",", ids), ParameterType.QueryString);
            }
        }

        protected void QueryBuilder(IRestRequest request, FilterQuery[] query) {

            if (query == null) return;
            
            int count = query.Length;
            var sb = new StringBuilder();

            foreach (var item in query) {
                count--;

                if (count > 1) {
                    sb.Append(item._ComparisonOperator);
                    sb.Append(":");
                    sb.Append(item._FieldValue);
                    sb.Append("+");
                    sb.Append(item._LogicOperator);
                    sb.Append("+");
                } else {
                    sb.Append(item._ComparisonOperator);
                    sb.Append(":");
                    sb.Append(item._FieldValue);
                }
                request.AddParameter(item._FieldName, sb.ToString(), ParameterType.QueryString);
            }
        }
    }
}
