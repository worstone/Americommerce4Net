#region License
//   Copyright 2014 Ken Worst - R.C. Worst & Company Inc.
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

namespace Americommerce4Net
{
    public interface IRestEngine
    {
        IClientResponse<bool> DeleteData(string resourceEndpoint);
        IClientResponse<T> GetData<T>(string resourceEndpoint) where T : new();
        IClientResponse<T> GetData<T>(string resourceEndpoint, IFilter filter) where T : new();
        IClientResponse<T> PostData<T>(string resourceEndpoint, string json) where T : new();
        IClientResponse<T> PutData<T>(string resourceEndpoint, string json) where T : new();
        bool CachingOn { get; set; }
    }


}
