using System;
namespace Americommerce4Net
{
    public interface IReadRepo<T>
    {
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> Get(global::Americommerce4Net.FilterMultiId filter);
        global::Americommerce4Net.IRepoResponse<T> Get(int id);
        global::Americommerce4Net.IRepoResponse<T> Get(int id, global::Americommerce4Net.FilterSingle filter);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> GetAll();
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> GetAll(global::Americommerce4Net.FilterList filter);
    }
}
