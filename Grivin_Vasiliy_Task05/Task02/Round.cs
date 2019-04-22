using System;
namespace Task02
{
    public class Round
    {

        public double Radius;
        public double CoordinatesX;
        public double CoordinatesY;
        public double pi = 3.14;
        private double circumference;
        private double squareround;

        public Round(double radius)
        {
            Radius = radius;
            Circumference = 0.0;
            SquareRound = 0.0;
        }

        public Round(double radius, double coordinatesX, double coordinatesY)
        {

            Radius = radius;
            CoordinatesX = coordinatesX;
            CoordinatesY = coordinatesY;
            Circumference = 0.0;
            SquareRound = 0.0;
        }
        //L=2πR L = circumference
        public double Circumference
        {
            get
            {
                return circumference;
            }

            set
            {
                if (Radius <= 0)
                {
                    Console.WriteLine("Проверьте введенный радиус");
                }
                circumference = 2 * pi * Radius;
            }
        }
        // square = pi * R * R
        public double SquareRound
        {
            get
            {
                return squareround;

            }

            set
            {
                if (Radius <= 0)
                {
                    Console.WriteLine("Проверьте введенный радиус");
                }
                squareround = pi * Radius * Radius;
            }
        }


    }
}
