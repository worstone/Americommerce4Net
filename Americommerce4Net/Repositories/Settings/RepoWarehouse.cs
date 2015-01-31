using Americommerce4Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Repositories
{
    public class RepoWarehouse : BaseRepoReadWrite<Warehouse>
    {
        readonly static IClientReadWrite _Client = new ClientSettings().Warehouses;

        public RepoWarehouse()
            : base(_Client, "warehouses") {
        }
    }
}
