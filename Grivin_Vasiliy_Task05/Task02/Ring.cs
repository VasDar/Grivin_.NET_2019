using System;
namespace Task02
{
    partial class Program
    {
        public class Ring
        {

            private Round Outer;
            private Round Inner;
            private double sumCircumferenceRing;
            private double squareRing;
            public double OuterRadius => Outer.Radius;
            public double InnerRadius => Inner.Radius;
            public Ring(double x, double y, double outerRadius, double innerRadius)
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

        }
    }
}
