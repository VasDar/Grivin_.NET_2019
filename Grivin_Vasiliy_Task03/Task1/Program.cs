using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите значение строки: ");
            String mainLine = Console.ReadLine();
            char[] delementChars = { ' ', ',', '.', ':', '?','!', '\t', '#', '%', '"', '$',
                '(',')','+','-', '/', '*',';','>','<','=','@','[',']','^','_','{','}', '|', '~'};

            string[] words = mainLine.Split(delementChars, StringSplitOptions.RemoveEmptyEntries);
            var temp = 0f;
            var count = 0f;
            foreach (var word in words)
            {
                if (!int.TryParse(word, out var parse))
                {
                    temp += word.Length;
                    count++;
                }
            }
            double Average = temp / count;
            Console.WriteLine(Average);


        }
    }
}
