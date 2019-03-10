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
            Console.Write("Ввидите значение ширины: ");
            int width = Int32.Parse(Console.ReadLine());
            if (width <= 0)
            {
                Console.WriteLine("Сорона не может быть ровна отрицательному значению или 0 ");
                Console.ReadKey();
                return;
            }
            Console.Write("Ввидите значение длины: ");
            int length = Int32.Parse(Console.ReadLine());
            if (length <= 0)
            {
                Console.WriteLine("Сторона не может быть ровна отрицательному значению или 0 ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Площадь прямоугольника равна: {width * length}");
            Console.ReadKey();
        }
    }
}
