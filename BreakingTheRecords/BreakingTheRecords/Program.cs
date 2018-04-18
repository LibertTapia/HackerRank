using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {
        /*
    * Complete the breakingRecords function below.
    */
        static int[] BreakingRecords(int[] score)
        {
            int[] breakingRecords = { 0, 0 };
            int highScore = score[0];
            int lowScore = score[0];

            foreach(int s in score)
            {
                if (s > highScore)
                {
                    breakingRecords[0]++;
                    highScore = s;
                }
                else if (s < lowScore)
                {
                    breakingRecords[1]++;
                    lowScore = s;
                }
            }
            return breakingRecords;
        }

        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
            ;
            int[] result = BreakingRecords(score);

            tw.WriteLine(string.Join(" ", result));

            tw.Flush();
            tw.Close();
        }
    }
}
