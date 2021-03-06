using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderPayment : BaseRepoReadWriteNested<Order_Payment>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderPayments;

        public RepoOrderPayment()
            : base(_Client, "payments") {
        }
    }
}
