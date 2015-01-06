using System;
using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderAddress : BaseRepoReadWrite<Order_Address>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderAddresses;

        public RepoOrderAddress()
            : base(_Client, "addresses") {
        }
    }
}