using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round exempleOne = new Round(27.5, 30, 30);
            Console.WriteLine($"Длина окружности равен: {exempleOne.Circumference} \n" +
                              $"Площадь ровна: {exempleOne.SquareRound}");
            Console.ReadKey();
        }
    }
}