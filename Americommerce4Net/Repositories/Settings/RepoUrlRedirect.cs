using Americommerce4Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public class RepoUrlRedirect : BaseRepoReadWrite<Url_Redirect>
    {
        readonly static IClientReadWrite _Client = new ClientSettings().UrlRedirects;

        public RepoUrlRedirect()
            : base(_Client, "url_redirects") {
        }
    }
}