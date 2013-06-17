using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class ShoppingCart : FlowersContainer
    {
        public ShoppingCart()
        {
            Flowers = new List<Flower>();
        }
    }
}
