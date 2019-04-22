using System;

namespace Task2
{
    public class Round
    {

        public double Radius;
        public double CoordinatesX;
        public double CoordinatesY;
        public double pi = 3.14;
        private double circumference;
        private double squareround;

        public Round(double radius, double coordinatesX, double coordinatesY)
        {
            Radius = radius;
            CoordinatesX = coordinatesX;
            CoordinatesY = coordinatesY;
        }
        //L=2πR L = circumference
        public double Circumference
        {
            get
            {
                if (Radius <= 0)
                {
                    Console.WriteLine("Проверьте введенный радиус");
                }
                circumference = 2 * pi * Radius;
                return circumference;
            }
        }
        // square = pi * R * R
        public double SquareRound
        {
            get
            {
                if (Radius <= 0)
                {
                    Console.WriteLine("Проверьте введенный радиус");
                }
                squareround = pi * Radius * Radius;
                return squareround;
            }
        }
    }
}
