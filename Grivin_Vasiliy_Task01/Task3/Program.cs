using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            string star = "*";
            for (int i = 0; i < height; i++)
            {
                for (int k = height; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i + i; j++)
                {

                    Console.Write(star);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
            
        }
    }
}
