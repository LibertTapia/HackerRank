using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            Int64 sum = 0;
            List<Int64> sumList = new List<Int64>();
            for(int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                    {
                        sum += arr[j];
                    }
                }
                sumList.Add(sum);
            }
            Console.WriteLine($"{sumList.Min()} {sumList.Max()}");
        }

        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            miniMaxSum(arr);
        }
    }
}
