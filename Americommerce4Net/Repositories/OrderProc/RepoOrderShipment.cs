using Americommerce4Net.Models;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderShipment : BaseRepoReadWrite<Order_Shipment>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderShipments;

        public RepoOrderShipment()
            : base(_Client, "shipments") {
        }
    }
}
