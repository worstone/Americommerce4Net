using System;
namespace Americommerce4Net
{
    public interface IClientRead
    {
        IClientResponse<dynamic> Get(FilterList filter);
        IClientResponse<dynamic> Get(FilterMultiId filter);
        IClientResponse<dynamic> Get(int recordId);
        IClientResponse<dynamic> Get(int recordId, FilterSingle filter);
    }
}
