using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        private static int DiagonalDifference(int[][] a)
        {
            int sum = 0;
            for(int r = 0; r < a.Length; r++)
            {
                for(int c = 0; c < a[r].Length; c++)
                {
                    if(r == c)
                    {
                        sum += a[r][c] - a[r][a[r].Length - r - 1];
                        break;
                    }
                }
            }
            return Math.Abs(sum);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = {
            new int[] { 11 ,2, 4},
            new int[] { 4, 5, 6 },
            new int[] { 10, 8, -12 }
            };

            /*
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }*/
            int result = DiagonalDifference(a);
            Console.WriteLine(result);
        }
    }
}
