using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            //n = ARRAY SIZE
            //k = DIVISORS
            //ar = ARRAY OF NUMBERS
            int result = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                for(int j = i+1; j < ar.Length; j++)
                {
                    int addition = ar[j] + ar[i];
                    if (addition > 0 && addition % k == 0)
                        result++;
                }
                
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}
