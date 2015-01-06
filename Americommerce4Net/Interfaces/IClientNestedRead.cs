using System;
namespace Americommerce4Net
{
    public interface IClientNestedRead : IClientRead
    {
        IClientResponse<dynamic> Get(int recordId, FilterSingleNested filter);
        IClientResponse<dynamic> Get(int recordId, string nestedResource, FilterNestedOnly filter);
    }
}
