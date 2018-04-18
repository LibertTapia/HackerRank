using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        public static void plusMinus()
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            float pos = 0f;
            float neg = 0f;
            float cero = 0f;

            foreach(int num in arr)
            {
                if (num > 0)
                {
                    pos++;
                }
                else if (num < 0)
                {
                    neg++;
                }
                else
                {
                    cero++;
                }
            }
            Console.WriteLine((pos / arr.Length).ToString("N6"));
            Console.WriteLine((neg / arr.Length).ToString("N6"));
            Console.WriteLine((cero / arr.Length).ToString("N6"));
        }

        static void Main(String[] args)
        {
            /*
             * 6
             * -4 3 -9 0 4 1 
             
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);*/
            plusMinus();
        }
    }
}
