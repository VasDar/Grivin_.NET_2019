using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void Output(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine($"array[{i + 1} {j + 1} {k + 1}]= {array[i, j, k]}");
                    }
                }
            }
        }

        public static void ChangeZero(int[,,] array)
            {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,,] arrayExemple = new int[3, 3, 3];
            Random rand = new Random();
            for (int i = 0; i < arrayExemple.GetLength(0); i++)
            {
                for (int j = 0; j < arrayExemple.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayExemple.GetLength(2); k++)
                    {
                        arrayExemple[i, j, k] = rand.Next(-10, 100);
                    }
                }
            }
          //Output(arrayExemple);
            ChangeZero(arrayExemple);
          //Console.WriteLine();
            Output(arrayExemple);
            Console.ReadKey();
        }
    }
}
