using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Internal");
            PrintBinary(1,6);
            Console.WriteLine("==========================================");
            Console.WriteLine("Manual");
            ManualPrintBinary(1, 6);
            Console.ReadLine();
        }

        private static void ManualPrintBinary(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}: {IntToBinary(i)}");
            }
        }

        private static object IntToBinary(int i)
        {
            string binary = String.Empty;
            int reminder;
            while (i > 0)
            {
                reminder = i % 2;
                i /= 2;
                binary = reminder.ToString() + binary;
            }
            return binary;
        }

        private static void PrintBinary(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}: {Convert.ToString(i,2)}");
            }
        }
    }
}
