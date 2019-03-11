using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
      /*public static void Output(int[,] array1)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine($"array[{j + 1} {i + 1}]=   {array1[i, j]}");
                }
            }
        }*/
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    array[i, j] = rand.Next(-10, 100);
                }
            }
            //Output(array);
            
            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        temp += array[i, j];
                    }
                }

            }
            Console.WriteLine($"Cумма на четных числах ровна: {temp}");
            Console.ReadKey();
        }
    }
}
