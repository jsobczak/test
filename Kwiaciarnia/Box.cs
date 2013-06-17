using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Box : FlowersContainer
    {
        public Customer Customer { get; set; }

        public Box(Customer customer)
        {
            Customer = customer;
            Flowers = new List<Flower>();
        }
    }
}
