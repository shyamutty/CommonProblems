using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                string numString = Console.ReadLine();

                string[] stringArray = numString.Split(' ');

                int[] arr = new int[stringArray.Length];

                for(int i = 0; i < stringArray.Length; i++)
                {
                    arr[i] = Convert.ToInt32(stringArray[i]);
                }

                Kadane(arr);
                n--;
            }
        }

        static void Kadane(int[] arr)
        {
            int numOfElements = arr.Length;
            int max = arr[0];
            int curr_max = arr[0];

            for (int i = 1; i < numOfElements; i++)
            {
                curr_max = Math.Max(arr[i] + curr_max, arr[i]);

                if (max < curr_max)
                {
                    max = curr_max;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
