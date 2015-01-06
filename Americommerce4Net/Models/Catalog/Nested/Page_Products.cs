using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Resources
{
    public class Page_Products : BasePage
    {
        public Page_Products() {
            products = new List<Product>();
        }
        public List<Product> products { get; set; }
    }
}
