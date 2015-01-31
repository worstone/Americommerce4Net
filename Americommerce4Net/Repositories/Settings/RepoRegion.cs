using Americommerce4Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public class RepoRegion : BaseRepoReadWrite<Region>
    {
        readonly static IClientReadWrite _Client = new ClientSettings().Regions;
        
        public RepoRegion()
            : base(_Client, "regions") {
        }
    }
}