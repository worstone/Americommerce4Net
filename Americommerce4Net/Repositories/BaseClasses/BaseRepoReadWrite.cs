#region License
//   Copyright 2015 Ken Worst - R.C. Worst & Company Inc.
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

using System.Collections.Generic;
using System;

namespace Americommerce4Net.Repositories
{
    public class BaseRepoReadWrite<T> : BaseRepoRead<T>, Americommerce4Net.IRepoReadWrite<T>
    {
        public BaseRepoReadWrite(IClientReadWrite readWriteClient, string resourceName)
            : base((IClientRead)readWriteClient, resourceName) {
            _ReadWriteClient = readWriteClient;
        }

        private IClientReadWrite _ReadWriteClient;
        protected IClientReadWrite ReadWriteClient {
            get {
                return _ReadWriteClient;
            }
        }

        public virtual IRepoResponse<T> Create(object obj) {
            var response = ReadWriteClient.Create(obj);
            var repo_response = new RepoResponse<T>();
            try {
                repo_response.Data = response.Data.ToObject<T>();
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }
            return repo_response;
        }

        public virtual IRepoResponse<T> Update(int id, object obj) {
            var response = ReadWriteClient.Update(id, obj);
            var repo_response = new RepoResponse<T>();
            try {
                repo_response.Data = response.Data.ToObject<T>();
                repo_response.ErrorException = response.RestResponse.ErrorException;
            } catch (Exception ex) {
                repo_response.ErrorException = ex;
            }
            return repo_response;

        }

        public virtual IRepoResponse<bool> Delete(int id) {
            var response = ReadWriteClient.Delete(id);
            var repo_response = new RepoResponse<bool>();
            repo_response.Data = response.Data;
            repo_response.ErrorException = response.RestResponse.ErrorException;
            return repo_response;
        }
    }
}
