namespace Americommerce4Net.Models
{
    public class InventorySettings
    {
        public bool track_inventory { get; set; }
        public string remove_from_inventory_when { get; set; }
        public int out_of_stock_product_status_id { get; set; }
        public int in_stock_product_status_id { get; set; }
        public int back_order_product_status_id { get; set; }
        public int discontinued_product_status_id { get; set; }
        public bool product_hide_no_inventory { get; set; }
    }
}
