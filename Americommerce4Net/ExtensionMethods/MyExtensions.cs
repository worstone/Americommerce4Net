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
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Americommerce4Net.ExtensionMethods
{
    public static class MyExtensions
    {
        public static Type GetListType<T>(this List<T> _) {
            return typeof(T);
        }
        public static string ObjectToJson(this object obj) {

            string json = JsonConvert.SerializeObject(obj, Formatting.None);
            return json;
        }

        public static string To_ISO_8601_DateTime_Format(this DateTime dateTime) {
            return dateTime.ToString("s") + dateTime.ToString("zzz");
            //return dateTime.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFK");
            //return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffffffzzz");
        }
    }
}
