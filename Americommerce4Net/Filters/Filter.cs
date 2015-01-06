using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net
{

    //List of resources
    //Single resource
    //Single resource with all nested resources populated
    //Nested resource list only
    //Multiple resources by identifier

    public class Filter : IFilter
    {
        readonly List<FilterQuery> _Queries = new List<FilterQuery>();

        public int? Page { get; set; }
        public int? Count { get; set; }
        public string[] Expand { get; set; }
        public string[] Sort { get; set; }
        public string[] Fields { get; set; }
        public int?[] ByIds { get; set; }

        public IEnumerable<FilterQuery> Query {
            get {
                return _Queries;
            }
            set {
                _Queries.AddRange(value);
            }
        }

        public void AddFilter(IRestRequest request) {
            QueryBuilder(request);
            PageBuilder(request);
            CountBuilder(request);
            ExpandBuilder(request);
            SortBuilder(request);
            FieldsBuilder(request);
            ByIdsBuilder(request);
        }

        
        #region Methods - Private
        private void PageBuilder(IRestRequest request) {
            if (this.Page != null) {
                request.AddParameter("page", this.Page, ParameterType.QueryString);
            }
        }

        private void CountBuilder(IRestRequest request) {
            if (this.Count != null) {
                request.AddParameter("count", this.Count, ParameterType.QueryString);
            }
        }

        private void ExpandBuilder(IRestRequest request) {
            if (this.Expand != null) {
                request.AddParameter("expand", string.Join(",", Expand), ParameterType.QueryString);
            }
        }
        private void SortBuilder(IRestRequest request) {
            if (this.Sort != null) {
                request.AddParameter("sort", string.Join(",", Sort), ParameterType.QueryString);
            }
        }
        private void FieldsBuilder(IRestRequest request) {
            if (this.Fields != null) {
                request.AddParameter("sort", string.Join(",", Fields), ParameterType.QueryString);
            }
        }
        private void ByIdsBuilder(IRestRequest request) {
            if (this.ByIds != null) {
                request.AddParameter("ids", string.Join(",", ByIds), ParameterType.QueryString);
            }
        }

        private void QueryBuilder(IRestRequest request) {

            int count = _Queries.Count;
            var sb = new StringBuilder();

            foreach (var item in _Queries) {
                count--;

                if (count > 1) {
                    sb.Append(item.Comparison.ToString());
                    sb.Append(":");
                    sb.Append(item.Value);
                    sb.Append("+");
                    sb.Append(item.Logic.ToString());
                    sb.Append("+");
                } else {
                    sb.Append(item.Comparison.ToString());
                    sb.Append(":");
                    sb.Append(item.Value);
                }
                request.AddParameter(item.FieldName, sb.ToString(), ParameterType.QueryString);
            }
        }
        #endregion
    }
}