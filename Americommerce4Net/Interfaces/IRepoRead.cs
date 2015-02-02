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

using System;

namespace Americommerce4Net
{
    public interface IRepoRead<T>
    {
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> Get(global::Americommerce4Net.FilterMultiId filter);
        global::Americommerce4Net.IRepoResponse<T> Get(int id);
        global::Americommerce4Net.IRepoResponse<T> Get(int id, global::Americommerce4Net.FilterSingle filter);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> Get_GreaterThanOrEqualTo_ModifiedDate(DateTime dateTime);
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> GetAll();
        global::Americommerce4Net.IRepoResponse<global::System.Collections.Generic.List<T>> GetAll(global::Americommerce4Net.FilterList filter);
    }
}
