using System;

namespace Task01
{
    class Line : Shape
    {
        public double CoordinateXPointB;
        public double CoordinateYPointB;
        public double CoordinateXPointA;
        public double CoordinateYPointA;
        private double lineLength;
        public Line(double coordinateXPointB,
                   double coordinateYPointB,
                    double xcentre,
                    double ycentre,
                    string name) : base(xcentre, ycentre, name)
        {
            CoordinateXPointA = xcentre;
            CoordinateYPointA = ycentre;
            CoordinateXPointB = coordinateXPointB;
            CoordinateYPointB = coordinateYPointB;
        }
        public double LineLength
        {
            get
            {
                return Math.Sqrt(Math.Pow((CoordinateXPointA - CoordinateXPointB), 2) +
                                 Math.Pow((CoordinateYPointA - CoordinateYPointB), 2));
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Название: {Name} \nДлина: {LineLength}");
            Console.WriteLine();
        }

    }
}
