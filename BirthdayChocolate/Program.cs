using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static int solve(int n, int[] s, int d, int m)
        {
            int count = 0;
            // n = number of squares
            //s = squares
            //d = how much the addition should be
            //m = number of consecutive squares
           for(int i = 0; i < n; i++)
            {
                int consecutive = AddNextConsecutive(m, i, s);
                if (consecutive == d)
                    count++;
            }
            return count;
        }

        static int AddNextConsecutive(int amount , int currentIndex, int[] s)
        {
            int result = 0;
            for(int i = 0; i < amount & (i+currentIndex) < s.Length; i++)
            {
                result += s[i + currentIndex];
            }
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}
