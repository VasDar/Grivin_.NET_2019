using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        public static bool CheckScientificNotation(string stringOne)
        {
            var value = false;
            string pattern = @"\de-\d";

            foreach (Match match in Regex.Matches(stringOne, pattern))
            {
                value = true;
            }

            return value;
        }

        public static bool CheckCommonNotation(string stringTwo)
        {
            var value = false || Double.TryParse(stringTwo, out double number);

            return value;
        }

        //Чтобы записать дробное число поставь ",", а не "."

        protected static void Main(string[] args)
        {
            Console.Write("Ввидите число: ");
            string stringMain = Console.ReadLine();
            Console.WriteLine();


            if (CheckScientificNotation(stringMain))
            {
                Console.WriteLine("Число в научной нотации.");
            }
            else if (CheckCommonNotation(stringMain))
            {
                Console.WriteLine("Число в обычной нотации.");
            }
            else
            {
                Console.WriteLine("Это не число.");
            }


        }
    }
}
