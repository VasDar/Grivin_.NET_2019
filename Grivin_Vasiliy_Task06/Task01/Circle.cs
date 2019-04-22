using System;

namespace Task01
{
    class Circle : Round
    {


        public Circle(double radius, double xcentre, double ycentre, string name) : base(radius, xcentre, ycentre, name)
        {
            Radius = radius;
        }
       
        public override void Draw()
        {
            Console.WriteLine($"Название: {Name} \nДлина окружности: {Circumference}");
            Console.WriteLine();
        }


    }


}
