using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        const string path = @"C:\Users\Vasiliy\Documents\Visual Studio 2017\Projects\Grivin_Vasiliy_Task11\Task1\disposable_task_file.txt";

        static void Main(string[] args)
        {
            string[] readNumbers = ReadFile(path);
            double[] modifyNumbers = Pow(readNumbers);

            readNumbers = ToStr(modifyNumbers);
            SetFile(path, readNumbers);

            Console.WriteLine("Процесс завершен!");
            Console.ReadKey();
        }

        public static string[] ReadFile(string path)
        {
            if (File.Exists(path))
            {
                var arr = File.ReadAllLines(path);
                return arr;
            }
            else
            {
                throw new FileNotFoundException("Файл не найден!");
            }

        }

        public static double[] Pow(string[] arr)
        {
            double[] newArr = new double[arr.Length];
            for (int i = 1; i < arr.Length; i++)
            {
                double num;
                if (double.TryParse(arr[i], out num))
                {
                    newArr[i] = Math.Pow(num, 2);
                }
            }

            return newArr;
        }

        public static string[] ToStr(double[] arr)
        {
            string[] newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i].ToString();
            }
            return newArr;
        }

        public static void SetFile(string path, string[] arr)
        {
            File.WriteAllLines(path, arr);
        }
    }
}
