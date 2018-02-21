using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaciSpaceOptimised
{
    //Time Complexity: O(n)
    //Extra Space: O(1)

    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(fib(n));
        }

        static int fib(int n)
        {
            int a = 0, b = 1, c;

            if (n == 0)
                return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
