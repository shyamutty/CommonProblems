using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            fib(5);

            Console.ReadKey();
        }

        static void fib(int m)
        {
            int n = 0;
            if (m == 0) return;
            n++;
            fib(-m);
            Console.WriteLine(m.ToString(), n.ToString());

        }

    }
}
