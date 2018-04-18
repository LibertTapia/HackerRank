using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// We are given an array A of positive integers, and two positive integers L and R (L <= R).
/// Return the number of(contiguous, non-empty) subarrays such that the value of the maximum array 
/// element in that subarray is at least L and at most R.
/// Example :
/// Input: 
/// A = [2, 1, 4, 3]
/// L = 2
/// R = 3
/// Output: 3
/// Explanation: There are three subarrays that meet the requirements: [2], [2, 1], [3].
/// </summary>
namespace NumberOfSubarraysWithBoundedMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] a = {2,1,2,4,3};
            int l = 2;
            int r = 3;

            SubArrayFinder(a, l, r);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadLine();
            
        }

        private static void SubArrayFinder(int[] a, int l, int r)
        {
            int j = 0;
            int count = 0; 
            int result = 0; 
            for (int i = 0; i < a.Length; i++) 
            {
                if (a[i] >= l && a[i] <= r)
                {
                    result += i - j + 1;
                    count = i - j + 1;
                }
                else if (a[i] < l)
                {
                    result += count;
                }
                else
                {
                    j = i + 1;
                    count = 0;
                }

            }
            Console.WriteLine(result);
        }
    }
}
