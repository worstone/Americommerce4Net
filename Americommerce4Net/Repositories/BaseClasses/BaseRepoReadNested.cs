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

using System;
using System.Collections.Generic;
using Americommerce4Net.ExtensionMethods;

namespace Americommerce4Net.Repositories
{
    public abstract class BaseRepoReadNested<T> : BaseRepoRead<T>, IRepoReadNested<T>
    {
        protected BaseRepoReadNested(IClientRead client, string resourceName)
            : base(client, resourceName) {
        }

        public virtual IRepoResponse<T> Get(int id, params string[] expandNested) {
            var filter = new FilterSingle().ExpandNested(expandNested);
            var response = ReadClient.Get(id, filter);

            var repo_response = new RepoResponse<T>();
            try {
                repo_response.Data = response.Data.ToObject<T>();
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }

            return repo_response;
        }

        public virtual IRepoResponse<List<T>> GetAll(params string[] expandNested) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("id")
                .FieldValue("0")
                .Compare_GreaterThan())
                .ExpandNested(expandNested);
            return RecordPaging(filter); ;
        }

        public virtual IRepoResponse<List<T>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime, params string[] expandNested) {
            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("updated_at")
                .FieldValue(dateTime.To_ISO_8601_DateTime_Format())
                .Compare_GreaterThanOrEqual())
                .ExpandNested(expandNested);

            return RecordPaging(filter);
        }
    }
}
