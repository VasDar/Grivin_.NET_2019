using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите HTML текст: ");
            String mainLine = Console.ReadLine();
            string output = Regex.Replace(mainLine, @"<[^>]*>", "_");
            Console.Write("Строка без тегов: ");
            Console.WriteLine(output);
        }
    }
}
