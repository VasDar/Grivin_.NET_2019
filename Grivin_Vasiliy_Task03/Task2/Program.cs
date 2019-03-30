using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool ComparisonLine(char c, string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.Write("Ввидите значение первой строки: ");
            String fistLine = Console.ReadLine();
            Console.Write("Ввидите значение второй строки: ");
            string secondLine = Console.ReadLine();

            for (int i = 0; i < fistLine.Length; i++)
            {
                if (ComparisonLine(fistLine[i], secondLine))
                {
                    Console.Write(fistLine[i]);
                }
                Console.Write(fistLine[i]);
            }

        }
    }
}
