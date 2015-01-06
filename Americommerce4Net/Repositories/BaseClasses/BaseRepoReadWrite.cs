using System.Collections.Generic;
using System;

namespace Americommerce4Net.Repositories
{
    public class BaseRepoReadWrite<T> : BaseRepoRead<T>
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
            repo_response.Data = response.Data.ToObject<T>();
            repo_response.ErrorException = response.RestResponse.ErrorException;
            return repo_response;
        }

        public virtual IRepoResponse<T> Update(int id, object obj) {
            var response = ReadWriteClient.Update(id, obj);
            var repo_response = new RepoResponse<T>();
            repo_response.Data = response.Data.ToObject<T>();
            repo_response.ErrorException = response.RestResponse.ErrorException;
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
