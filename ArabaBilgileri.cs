using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BTKArabaBilgileri:IGaleri
    {
        public string GetAraba()
        {
            string araba = "Range Rover\tSiyah\t2020Model\n";
            araba += "Mercedes\tBeyaz\t2018Model\n";
            araba += "BMW\t\ttmavi\t2019Model\n";
            araba += "Fiat\t\tkirmizi\t2015Model\n";
            araba += "Ford\t\tyeşil\t2000Model\n";
            return araba;

        }
    }
}
