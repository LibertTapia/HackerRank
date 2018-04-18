using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        private static long AVeryBigSum(int n, long[] ar)
        {
            long sum = 0;
            foreach(long lar in ar)
            {
                sum += lar;
            }
            return sum;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = AVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}
