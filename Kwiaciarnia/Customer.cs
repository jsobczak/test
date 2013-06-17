using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Customer
    {
        // imie klienta
        public string Name { get; set; }

        // pieniadze ktorymi dysponuje klient
        public int Cash { get; set; }

        // wozek
        public ShoppingCart ShoppingCart { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">imie</param>
        /// <param name="money">kwota</param>
        public Customer(string name, int money)
        {
            Name = name;
            Cash = money;
            ShoppingCart = new ShoppingCart();
        }

        /// <summary>
        /// Metoda umieszka kwiat w koszyku klienta
        /// </summary>
        /// <param name="flower"></param>
        public void Get(Flower flower)
        {
            ShoppingCart.Flowers.Add(flower);
        }

        /// <summary>
        /// klient płaci za zawartość koszyka
        /// </summary>
        public void Pay()
        {
            for (int i = ShoppingCart.Flowers.Count - 1; i >= 0; i--)
            {
                try
                {
                    if (Cash >= PriceList.Instance.Prices[ShoppingCart.Flowers[i].Name] * ShoppingCart.Flowers[i].Count) // klienta stać na wszystkie kwiatki tego typu
                        Cash -= PriceList.Instance.Prices[ShoppingCart.Flowers[i].Name] * ShoppingCart.Flowers[i].Count;
                    else    // płaci za tyle, na ile mu wystarczy pieniędzy, reszte wyrzuca z koszyka
                    {
                        int numCanAfford = Cash / PriceList.Instance.Prices[ShoppingCart.Flowers[i].Name];
                        Cash -= numCanAfford * PriceList.Instance.Prices[ShoppingCart.Flowers[i].Name];
                        ShoppingCart.Flowers[i].Count -= ShoppingCart.Flowers[i].Count - numCanAfford;
                        if (ShoppingCart.Flowers[i].Count == 0)
                            ShoppingCart.Flowers.RemoveAt(i);
                    }
                }
                catch (KeyNotFoundException)    // nie ma ceny dla tego kwiatka - jest usuwany
                {
                    ShoppingCart.Flowers.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// klient pakuje pudełko
        /// </summary>
        /// <param name="box"></param>
        public void Pack(Box box)
        {
            box.Flowers.AddRange(ShoppingCart.Flowers);
            ShoppingCart.Flowers.Clear();
        }
    }
}
