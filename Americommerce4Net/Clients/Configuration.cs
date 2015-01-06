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
using System.Configuration;

namespace Americommerce4Net
{
    public class Configuration
    {
        public string ServiceURL { get; set; }
        public string ApiAccessToken { get; set; }
        public int ErrorRetryMax { get; set; }
        public int ErrorRetryDelay { get; set; }
        public int RequestTimeout { get; set; }
        public bool ThrottlingEnabled { get; set; }
        public int ThrottlingDelay { get; set; }
        public bool AllowDeletions { get; set; }
        public bool EnableInfoLogging { get; set; }

        public Configuration(string serviceURL, string apiAccessToken) {
            ServiceURL = serviceURL;
            ApiAccessToken = apiAccessToken;
            ErrorRetryMax = 5;
            ErrorRetryDelay = 60000;
            RequestTimeout = 20000;
            ThrottlingEnabled = true;
            ThrottlingDelay = 11000;
            AllowDeletions = false;
            EnableInfoLogging = true;
        }

        public Configuration() {
            GetConfiguration();
        }

        private void GetConfiguration() {

            ServiceURL = ConfigurationManager.AppSettings["ServiceURL"];
            ApiAccessToken = ConfigurationManager.AppSettings["ApiAccessToken"];
            RequestTimeout = int.Parse(ConfigurationManager.AppSettings["RequestTimeout"]);
            ErrorRetryMax = int.Parse(ConfigurationManager.AppSettings["ErrorRetryMax"]);
            ErrorRetryDelay = int.Parse(ConfigurationManager.AppSettings["ErrorRetryDelay"]);
            ThrottlingEnabled = Boolean.Parse(ConfigurationManager.AppSettings["ThrottlingEnabled"]);
            ThrottlingDelay = int.Parse(ConfigurationManager.AppSettings["ThrottlingDelay"]);
            AllowDeletions = Boolean.Parse(ConfigurationManager.AppSettings["AllowDeletions"]);
            EnableInfoLogging = Boolean.Parse(ConfigurationManager.AppSettings["EnableLogging"]);
        }
    }
}
