using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
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

                for (int i = 0; i < stringArray.Length; i++)
                {
                    arr[i] = Convert.ToInt32(stringArray[i]);
                }

                MissingNumber(num, arr);

                n--;
            }
        }

        static void MissingNumber(int num, int[] arr)
        {
            bool[] boolArr = new bool[num];
            for(int i = 0; i < num; i++)
            {
                if (arr[i] != i)
                    Console.WriteLine(i);
            }

        }
    }
}
