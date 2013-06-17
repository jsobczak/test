using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Orchid : Flower
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="count"></param>
        public Orchid(int count, string color = "rozowy")
        {
            Count = count;
            Color = color;
            name = "orchidea";
        }
    }
}
