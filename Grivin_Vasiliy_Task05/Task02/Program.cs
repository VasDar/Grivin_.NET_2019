using System;

namespace Task02
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            Ring exempleOne = new Ring(0, 0, 1, 2);
            Console.WriteLine($"Длина окружности равен: {exempleOne.SumCircumferenceRing} \n" +
                              $"Площадь ровна: {exempleOne.SquareRing}");
            Console.ReadKey();
           //L=2πR L = circumference
            // square = pi * R * R
        }
    }
}
