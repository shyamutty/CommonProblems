using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciDymamic
{
    //Time Complexity: O(n)
    //Extra Space: O(n)
    ///https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    class Fibonacci
    {
        static int MAX = 100;
        static int NIL = -1;
        int [] lookup = new int[MAX];
        int i = 0;

        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
            int n = 40;
            f._initialize();
            Console.WriteLine("Fibonacci number is : " + f.fib(n));
            Console.WriteLine("Lookup Table: ");

            foreach (var item in f.lookup)
            {
                Console.WriteLine(f.i++ + " " + item);
            }

            Console.ReadKey();
        }

        void _initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        int fib(int n)
        {
            if (lookup[n] == NIL)
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                    lookup[n] = fib(n - 1) + fib(n - 2);
            }
            return lookup[n];
        }
    }
}
