using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public abstract class Flower
    {
        // liczba kwiatow
        public int Count { get; set; }

        // kolor
        public string Color { get; set; }

        // nazwa - atrybut z możliwością modyfikacji tylko w klasach dziedziczących, 
        // dla reszty tylko do odczytu
        protected string name;

        public string Name
        {
            get { return name; }
        }
    }
}
