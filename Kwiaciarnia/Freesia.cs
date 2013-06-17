using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Freesia : Flower
    {
        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="count"></param>
        public Freesia(int count, string color = "żółty")
        {
            Count = count;
            Color = color;
            name = "frezja";
        }
    }
}
