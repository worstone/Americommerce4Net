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

using Americommerce4Net.Clients;

namespace Americommerce4Net
{
    public class ClientContent
    {

        IRestEngine _RestEngine;

        public ClientContent() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientContent(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientContent(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }


        private ClientPages _Pages;
        public ClientPages Pages {
            get {
                if (_Pages == null) {
                    _Pages = new ClientPages(_RestEngine);
                }
                return _Pages;
            }
        }

        private ClientBlogs _Blogs;
        public ClientBlogs Blogs {
            get {
                if (_Blogs == null) {
                    _Blogs = new ClientBlogs(_RestEngine);
                }
                return _Blogs;
            }
        }

        private ClientBlogCategories _BlogCategories;
        public ClientBlogCategories BlogCategories {
            get {
                if (_BlogCategories == null) {
                    _BlogCategories = new ClientBlogCategories(_RestEngine);
                }
                return _BlogCategories;
            }
        }

        private ClientBlogPosts _BlogPosts;
        public ClientBlogPosts BlogPosts {
            get {
                if (_BlogPosts == null) {
                    _BlogPosts = new ClientBlogPosts(_RestEngine);
                }
                return _BlogPosts;
            }
        }

        private ClientLinks _Links;
        public ClientLinks Links {
            get {
                if (_Links == null) {
                    _Links = new ClientLinks(_RestEngine);
                }
                return _Links;
            }
        }
    }
}
