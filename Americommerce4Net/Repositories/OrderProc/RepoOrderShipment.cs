using Americommerce4Net.Models;
using System.Collections.Generic;

namespace Americommerce4Net.Repositories
{
    public class RepoOrderShipment : BaseRepoReadWriteNested<Order_Shipment>
    {
        readonly static IClientReadWrite _Client = new ClientOrderProc().OrderShipments;

        public RepoOrderShipment()
            : base(_Client, "shipments") {
        }

        public IRepoResponse<List<Order_Shipment>> GetByOrderNumber(int order_number, params string[] expandNested) {

            var filter = new FilterList()
                .Query(new FilterQuery()
                .FieldName("order_id")
                .FieldValue(order_number.ToString())
                .Compare_EqualTo())
                .ExpandNested(expandNested);

            return base.RecordPaging(filter);
        }
    }
}
