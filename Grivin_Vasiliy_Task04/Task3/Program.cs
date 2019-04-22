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
            Triangel exempleOne = new Triangel(27.5, 30, 30);
            Console.WriteLine($"Периметр равен: {exempleOne.Perimeter} \n" +
                              $"Площадь ровна: {exempleOne.Area}");
            Console.ReadKey();
        }
    }
}
