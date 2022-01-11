using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money2
{
    class Program
    {
        static void Main(string[] args)
        {
            Money mon1 = new Money();
            mon1.Grivna = 15;
            mon1.Kopiyka = 78;
            mon1[1] = 90;
            Money mon2 = new Money(10, 23);

            Money total = mon1 + mon2;
            Console.WriteLine($"Money mon1:{mon1}");
            Console.WriteLine($"Money mon2:{mon2}");
            Console.WriteLine($"Total money:{total}");

            
            Console.WriteLine($"Total in dollar:{total.ToDollar()}");
            total.FromDollar(100);
            Console.WriteLine($"Total money:{total}");

        }
    }
}
