using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            for(int i = 0; i <= 10000; i++)
            {
                if(i*v1 + x1 == i*v2 + x2)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = Kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
