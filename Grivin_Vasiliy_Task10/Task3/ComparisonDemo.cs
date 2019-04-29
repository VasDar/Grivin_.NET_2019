using System;

namespace Task3
{
    public class ComparisonDemo
    {
        public static void Demo(string[] args)
        {
            TwoDPoint point1 = new TwoDPoint(1, 10);
            TwoDPoint point2 = new TwoDPoint(1, 10);

            object object1 = (object)point1;
            object object2 = (object)point2;

            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(point1 == point2);

            Console.WriteLine(object1.Equals(object2));
            Console.WriteLine(object1 == object2); 
        }
    }
}
