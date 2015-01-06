using System;
using System.Collections.Generic;
using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderStatus : BaseRepoReadWrite<Order_Status>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderStatuses;

        public RepoOrderStatus()
            : base(_Client, "order_statuses") {
        }
    }
}