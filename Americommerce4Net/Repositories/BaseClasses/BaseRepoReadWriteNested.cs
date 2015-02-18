using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public abstract class BaseRepoReadWriteNested<T> : BaseRepoReadNested<T>, Americommerce4Net.IRepoReadWrite<T>
    {
        public BaseRepoReadWriteNested(IClientReadWrite readWriteClient, string resourceName)
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
