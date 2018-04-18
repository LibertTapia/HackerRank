using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparetheTriplets
{
    class Program
    {
        private static int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] A = { a0, a1, a2 };
            int[] B = { b0, b1, b2 };
            int bob = 0;
            int alice = 0;
            for(int i =0; i < A.Length; i++)
            {
                if (A[i] > B[i])
                    alice++;
                else if (A[i] < B[i])
                    bob++;
                    
            }
            return new int[]{ alice , bob };
        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();

        }
    }
}
