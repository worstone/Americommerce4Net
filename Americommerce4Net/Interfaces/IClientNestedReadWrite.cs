using System;

namespace Americommerce4Net
{
    public interface IClientNestedReadWrite : IClientNestedRead
    {
        IClientResponse<dynamic> Create(object obj);
        IClientResponse<dynamic> Create(string json);
        IClientResponse<dynamic> Update(int recordId, object obj);
        IClientResponse<dynamic> Update(int recordId, string json);
        IClientResponse<bool> Delete(int recordId);
    }
}
