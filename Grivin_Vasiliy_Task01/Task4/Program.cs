using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите число треугольников: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Число треугольников не может быть ровна отрицательному значению или 0 ");
                Console.ReadKey();
                return;
            }
            string star = "*";

            for (int l = 0; l < number; l++)
            {
                for (int i = 0; i <= l; i++)
                {
                    for (int k = 0; k < number - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i + i; j++)
                    {
                        Console.Write(star);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
           
        }
    }
}
