using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public abstract class FlowersContainer
    {
        public List<Flower> Flowers { get; set; }

        public override string ToString()
        {
            string result = "";
            if (this is ShoppingCart)
                result += "Wózek";
            else if (this is Box)
                result += "Pudełko";
            if (Flowers.Count == 0)
                return result + "--pusto";
            foreach (var flower in Flowers)
            {
                result += "\n" + flower.Name +
                    ", kolor " + flower.Color +
                    ", ilość " + flower.Count +
                    ", cena ";
                try
                {
                    result += PriceList.Instance.Prices[flower.Name];
                }
                catch (KeyNotFoundException)
                {
                    result += "nieznana";
                }
            }
            return result;
        }
    }
}
