using System;

namespace Americommerce4Net
{
    public interface IRepoReadNested<T> : IRepoRead<T>
    {
        global::Americommerce4Net.IRepoResponse<T> Get(int id, params string[] expandNested);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime, params string[] expandNested);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> GetAll(params string[] expandNested);
    }
}
