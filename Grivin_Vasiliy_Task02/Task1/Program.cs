using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i+1}]=   {array[i]}");
            }
        }

        public static void SortArray(int[] array)
        {
            
            for (int j = 0; j < array.Length; j++)
            {
                
                for (int i = 0; i < array.Length -1; i++)
                {
                    int temp = 0;
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var arrayExemple = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arrayExemple.Length; i++)
            {
                arrayExemple[i] = rand.Next(-10, 100);
            }
            // Output(arrayExemple);
            SortArray(arrayExemple);
           // Console.WriteLine();
            Output(arrayExemple);
            
            Console.ReadKey();
        }
    }
}
