using System;
using System.Collections.Generic;

namespace Task2
{
    interface IIndexable<T>
    {
        T this[int index] { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { 1, 2, 3, 4, 5 };

            List<int> list = new List<int>();

            list.Add(9);
            list.Add(8);
            list.Add(2);

            DynamicArray<int> dynamicArray = new DynamicArray<int>(list);

            foreach (var a in dynamicArray)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}