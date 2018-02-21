using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    //https://www.mathsisfun.com/numbers/golden-ratio.html
    //https://www.geeksforgeeks.org/time-complexity-recursive-fibonacci-program/
    //Complexity: O(1.618) ^ n
    //Time Complexity: T(n) = T(n-1) + T(n-2) which is exponential.

    class Fibonnaci
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine("Fibonacci number is: " + fib(n));
            Console.ReadKey();
        }

        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
