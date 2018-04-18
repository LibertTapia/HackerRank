using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine($"{new string('^',n-i-1)}{new string('#',i+1)}");
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
    }
}
