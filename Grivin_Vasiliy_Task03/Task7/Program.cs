using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            Console.WriteLine("Ввидите значение текста: ");
            string stringMain = Console.ReadLine();
            char[] delementChars = { ' ', ',', '.' };
            string[] words = stringMain.Split(delementChars, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"([0-1]?[0-9]|2[0-3]):[0-5][0-9]$", RegexOptions.Multiline);
            foreach (string str in words)
            {
                if (regex.IsMatch(str))
                    count++;
            }
            Console.WriteLine($"Время в данном тексте присутсвует {count} раз.");

        }
    }
}
