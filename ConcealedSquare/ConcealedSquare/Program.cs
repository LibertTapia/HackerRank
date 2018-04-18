using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcealedSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] expectedAnswer = Console.ReadLine().Split(' ');
            
            int[] ar = Array.ConvertAll(expectedAnswer, Int32.Parse);
            
            int result = 3;
            int startIndex = 0;
            int j = 0;
            do
            {

                var answer = Math.Pow(result, 2);
                string[] dividedAnswer = answer.ToString().ToCharArray().Select(x => x.ToString()).ToArray();
                
                for(int i = startIndex; i < dividedAnswer.Length; i++)
                {

                    for()
                }
                ;
              result++;  
            }while(true);
        }
    }
}
