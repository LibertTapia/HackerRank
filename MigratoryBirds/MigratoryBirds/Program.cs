using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(int n, int[] ar)
        {
            Dictionary<int, int> spotted = new Dictionary<int, int>
            {
                [1] = 0 ,
                [2] = 0,
                [3] = 0,
                [4] = 0,
                [5] = 0,
            };

            foreach(int type in ar)
            {
                spotted[type]++;
            }
            return spotted.First(x => x.Value == spotted.Values.Max()).Key;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}
