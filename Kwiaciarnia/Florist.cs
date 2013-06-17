using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwiaciarnia
{
    public class Florist
    {
        public Florist()
        {
            PriceList pl = PriceList.Instance;
            pl.Set("róża", 10);
            pl.Set("bez", 12);
            pl.Set("piwonia", 8);
            pl.Set("orchidea", 14);
        }
    }
}
