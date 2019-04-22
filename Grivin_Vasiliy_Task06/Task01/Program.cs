using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    interface IDraw
    {
        void Draw();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] arrayShape = new Shape[]{new Line(5, 4, 3, 4, "Линия"),
                                           new Rectangle(24, 36, "Прямоугольник"),
                                           new Circle(10, 2, 3, "Окружность"),
                                           new Round(12, 12, 13, "Круг"),
                                           new Ring(12, 12, 10, 15, "Кольцо")};
            foreach (Shape temp in arrayShape)
            {
                temp.Draw();
            }
            Console.ReadKey();
        }

    }
}
