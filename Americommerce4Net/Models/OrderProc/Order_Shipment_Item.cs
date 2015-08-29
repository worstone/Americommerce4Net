using System;

namespace Americommerce4Net.Models
{
    public class Order_Shipment_Item : BaseAudit, IResource
    {
        public int id { get; set; }
        public int quantity_shipped { get; set; }
        public int product_id { get; set; }
        public string item_name { get; set; }
    }
}
