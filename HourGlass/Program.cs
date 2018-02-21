using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[,]
                            {
                                {1, 2, 3, 0, 0},
                                {0, 0, 0, 0, 0},
                                {2, 1, 4, 0, 0},
                                {0, 0, 0, 0, 0},
                                {1, 1, 0, 1, 0}
                            };

            int res = findMaxSum(mat);

            Console.WriteLine("Maximum sum of hour glass : " + res);
            Console.ReadKey();
        }

        static int findMaxSum(int[,] mat)
        {
            int R = mat.GetUpperBound(0);
            int C = mat.GetUpperBound(1);

            if (R < 3 || C < 3)
                return -1;

            int max_sum = 0;
            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    // Considering mat[i][j] as top left cell of
                    // hour glass.
                    int sum = (mat[i,j] + mat[i,j + 1] + mat[i,j + 2]) +
                              (mat[i + 1,j + 1]) +
                          (mat[i + 2,j] + mat[i + 2,j + 1] + mat[i + 2,j + 2]);

                    // If previous sum is less then current sum then
                    // update new sum in max_sum
                    max_sum = Math.Max(max_sum, sum);
                }
            }

            return max_sum;
        }
    }


}
