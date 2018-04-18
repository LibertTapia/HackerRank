using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {
        /*
       * Complete the getTotalX function below.
       */
        private static int LCM(int value1, int value2)
        {
            value1 = Math.Abs(value1);
            value2 = Math.Abs(value2);
            value1 = value1 / GCD(value1, value2);
            return value1 * value2;
        }

        private static int LCM(int[] a)
        {
            int lcm = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                lcm = LCM(lcm, a[i]);
            }
            return lcm;
        }
        private static int GCD(int[] b)
        {
            int gcd = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                gcd = GCD(gcd, b[i]);
            }
            return gcd;
        }
        private static int GCD(int value1, int value2)
        {
            int gcd = 0;
            if (value2 == value1)
                return value1;
            if (value1 > value2 && value1 % value2 == 0)
                return value2;
            if (value2 > value1 && value2 % value1 == 0)
                return value1;

            while (value2 != 0)
            {
                gcd = value2;
                value2 = value1 % value2;
                value1 = gcd;
            }
            return gcd;
        }

        static int getTotalX(int[] a, int[] b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int count = 0;
            int lcm = LCM(a);
            
            int gcm = GCD(b);
            for (int i = lcm, j = 2; i <= gcm; i = lcm * j, j++)
            {
                if (gcm % i == 0)
                    count++;
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalMinutes.ToString());
            return count;
        }


        /*static int getTotalX(int[] a, int[] b)
        {
            
            int c = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (a.Any(x => i % x != 0)) continue;
                if (b.Any(x => x % i != 0)) continue;
                c++;
            };
            return c;
        }*/
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));
            int total = getTotalX(a, b); 
        }
    }
}
