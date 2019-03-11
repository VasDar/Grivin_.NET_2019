using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /*  public static void Output(int[] array1)
          {
              for (int i = 0; i < array1.Length; i++)
              {
                  Console.WriteLine($"array[{i + 1}]= {array1[i]}");
              }
          }*/
        static void Main(string[] args)
        {
            int[] arrayExempl = new int[100];
            Random rand = new Random();
            for (int i = 0; i < arrayExempl.Length; i++)
            {
                arrayExempl[i] = rand.Next(-10, 100);
            }

            //Output(arrayExempl);
            //Console.WriteLine();
            int temp = 0;
            for (int i = 0; i < arrayExempl.Length; i++)
            {
                if (arrayExempl[i] > 0)
                {
                    temp += arrayExempl[i];
                }
            }
            Console.WriteLine($"Сумма не отрицательных элементов ровна: {temp}");
            Console.ReadKey();
        }
    }
}
