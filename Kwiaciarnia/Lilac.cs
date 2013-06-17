using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Lilac : Flower
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="count"></param>
        public Lilac(int count, string color = "biały")
        {
            Count = count;
            Color = color;
            name = "bez";
        }
    }
}
