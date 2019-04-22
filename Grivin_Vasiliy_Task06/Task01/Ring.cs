using System;
namespace Task01
{
    class Ring : Shape
    {
        private Round Outer;
        private Round Inner;
        private double sumCircumferenceRing;
        private double squareRing;
        public double OuterRadius => Outer.Radius;
        public double InnerRadius => Inner.Radius;
        public Ring(double x, double y, double outerRadius, double innerRadius, string name) : base( name)
        {

            Outer = new Round(outerRadius);
            Inner = new Round(innerRadius);

        }

        public double SumCircumferenceRing
        {
            get
            {
                return Outer.Circumference + Inner.Circumference; ;
            }

        }
        public double SquareRing
        {
            get
            {
                return Inner.SquareRound - Outer.SquareRound; ;
            }

        }
        public override void Draw()
        {
            Console.WriteLine($"Название: {Name} \nДлина окружностeй: {SumCircumferenceRing} \nПлощадь кольца: {SquareRing}");
            Console.WriteLine();

        }

    }
}
