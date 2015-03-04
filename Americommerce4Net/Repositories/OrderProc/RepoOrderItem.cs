using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderItem : BaseRepoReadWrite<Order_Item>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderItems;

        public RepoOrderItem()
            : base(_Client, "items") {
        }
    }
}
