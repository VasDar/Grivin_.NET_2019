using System;
namespace Task01
{
    class Rectangle : Shape
    {

        public double LengthRectangel;
        public double WidthRectangel;
        private double squareRectange;
        private double perimeterRectangle;

        public Rectangle(double lingthRectangel,
                         double widthRectangel,
                         string name) : base(name)
        {
            LengthRectangel = lingthRectangel;
            WidthRectangel = widthRectangel;

        }
        public double SquareRectange
        {
            get
            {
                return LengthRectangel * WidthRectangel;
            }
        }
        public double PerimeterRectangle
        {
            get
            {
                return (2 * LengthRectangel) + (2 * WidthRectangel);
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Название: {Name} \nПлощадь: {SquareRectange} \nПериметр: {PerimeterRectangle}");
            Console.WriteLine();
        }

    }
}
