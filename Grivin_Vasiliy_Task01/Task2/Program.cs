using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите высоту: ");
            int height = Int32.Parse(Console.ReadLine());
            if (height <= 0)
            {
                Console.WriteLine("Высота не может быть ровна отрицательному значению или 0 ");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i <= height; i++)
            {
                string star = new string('*', i);
                Console.WriteLine(star);
            }
            Console.ReadKey();
        }
    }
}
