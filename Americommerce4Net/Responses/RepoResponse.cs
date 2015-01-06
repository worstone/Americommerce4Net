
using System;

namespace Americommerce4Net
{
    public class RepoResponse<T> : IRepoResponse<T>
    {
        public T Data { get; set; }
        public Exception ErrorException { get; set; }
    }
}
