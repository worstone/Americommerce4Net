using System;

namespace Americommerce4Net
{
    public interface IRepoResponse<T>
    {
        T Data { get; set; }
        Exception ErrorException { get; set; }
    }
}
