using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Methods
{
    internal class Screen
    {
        public static int ReadNumber(string message)
        {
            int number;
            bool isSuccess = true;
            do
            {
                Console.WriteLine(message);
                isSuccess = int.TryParse(Console.ReadLine(), out number);

            } while (!isSuccess);
            return number;
        }
        public static void WriteToScreen(string message)
        {
            Console.WriteLine(message);
        }
        public static void ClearScreen()
        {
            Console.Clear();
        }
        public static void NewLine()
        {
            Console.WriteLine();
        }
    }
}
