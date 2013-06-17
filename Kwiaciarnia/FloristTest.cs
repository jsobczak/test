using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    class FloristTest
    {
        /// <summary>
        /// metoda zwraca wartosc kwiatow w pudelku o podanym kolorze
        /// </summary>
        /// <param name="box"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int valueOf(Box box, string color)
        {
            int value = 0;
            foreach (var flower in box.Flowers)
            {
                if (flower.Color == color)
                    value += flower.Count * PriceList.Instance.Prices[flower.Name];
            }
            return value;
        }

        static void Main(string[] args)
        {
            Florist florist = new Florist();

            Customer janek = new Customer("Janek", 200);
            janek.Get(new Rose(5));
            janek.Get(new Peony(5));
            janek.Get(new Freesia(3));
            janek.Get(new Lilac(3));
            //janek.Get(new Orchid(3));

            Console.WriteLine("Przed płaceniem\n" + janek.ShoppingCart);

            janek.Pay();

            Console.WriteLine("Po zapłaceniu\n" + janek.ShoppingCart);
            Console.WriteLine("Jankowi zostało : " + janek.Cash + " zł");

            Box pudelkoJanka = new Box(janek);
            janek.Pack(pudelkoJanka);

            Console.WriteLine("Po zapakowaniu do pudełka\n" + janek.ShoppingCart);
            Console.WriteLine(pudelkoJanka);
            Console.WriteLine("Czerwone kwiaty w pudełku Janka kosztowały: " + valueOf(pudelkoJanka, "czerwony"));

            Customer stefan = new Customer("Stefan", 60);
            stefan.Get(new Lilac(3));
            stefan.Get(new Rose(5));

            Console.WriteLine(stefan.ShoppingCart);
            stefan.Pay();
            Box pudelkoStefana = new Box(stefan);
            stefan.Pack(pudelkoStefana);

            Console.WriteLine(pudelkoStefana);
            Console.WriteLine("Stefanowi zostało : " + stefan.Cash + " zł");

            Console.ReadLine();
        }
    }
}
