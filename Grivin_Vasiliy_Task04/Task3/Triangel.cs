using System;

namespace Task3
{
    public class Triangel
    {
        public double SideA;
        public double SideB;
        public double SideC;
        private double perimeter;
        private double area;

        public Triangel(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Perimeter
        {
            get
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    Console.WriteLine("Проверьте введенные данные");
                }
                perimeter = SideA + SideB + SideC;
                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                return area = perimeter / 2 * (perimeter / 2 - SideA) * (perimeter / 2 - SideB) * (perimeter / 2 - SideC);

            }
        }
    }
}
