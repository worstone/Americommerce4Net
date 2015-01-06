using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Americommerce4Net.Resources
{
    public class Wrap_Products : BaseWrap
    {
        public Wrap_Products() {
            products = new List<Product>();
        }
        public List<Product> products { get; set; }
    }
}