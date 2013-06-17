using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Rose : Flower
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="count"></param>
        public Rose(int count, string color = "czerwony")
        {
            Count = count;
            Color = color;
            name = "róża";
        }
    }
}
