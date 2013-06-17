using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    /// <summary>
    /// Klasa singletonowa cennika
    /// </summary>
    public class PriceList
    {
        // instancja
        private static PriceList instance;

        // ceny
        public Dictionary<string, int> Prices { get; set; }

        /// <summary>
        /// prywatny konstruktor
        /// </summary>
        private PriceList()
        {
            Prices = new Dictionary<string, int>();
        }

        /// <summary>
        /// metoda zwraca instancję klasy, tworzy nową jeśli nie istnieje
        /// </summary>
        public static PriceList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PriceList();
                }
                return instance;
            }
        }

        /// <summary>
        /// metoda dodaje element do cen
        /// </summary>
        /// <param name="item"></param>
        /// <param name="price"></param>
        public void Set(string item, int price)
        {
            Prices.Add(item, price);
        }
    }
}
