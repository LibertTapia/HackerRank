using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "LibertTapia"; // ORIGINAL WORD
            var wordArray = word.ToArray(); //CONVERT TO ARRAY

            foreach(Char c in wordArray)
            {
                if (wordArray.Where(w => w == c).Count() > 1)
                {
                    Console.WriteLine($"First Repeating Character: {c}");
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
