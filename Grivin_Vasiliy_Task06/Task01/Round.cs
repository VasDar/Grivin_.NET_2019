using System;

namespace Task01
{
    class Round : Shape
    {

        public double Radius;


        private double circumference;
        private double squareround;

        public Round(double radius)
        {
            Radius = radius;
            Circumference = 0.0;
            SquareRound = 0.0;
        }
        public Round(double radius, double xcentre, double ycentre, string name) : base(xcentre, ycentre, name)
        {
            Radius = radius;
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
                circumference = 2 * Math.PI * Radius;
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
                squareround = Math.PI * Radius * Radius;
            }
        }
        public override void Draw()
        {
            Console.WriteLine($"Название: {Name} \nДлина окружности: {Circumference} \nПлощадь круга: {SquareRound}");
            Console.WriteLine();
        }
    }
}
