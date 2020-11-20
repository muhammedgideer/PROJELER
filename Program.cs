using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IGaleri proxy = new ProxyAraba();
            Console.WriteLine(proxy.GetAraba());


            Console.WriteLine(proxy.GetAraba());

            Console.ReadLine();
        }
    }
}
