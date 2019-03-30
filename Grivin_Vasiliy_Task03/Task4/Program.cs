using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch0 = new System.Diagnostics.Stopwatch();
            System.Diagnostics.Stopwatch stopwatch1 = new System.Diagnostics.Stopwatch();

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 1000;
            stopwatch0.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopwatch0.Stop();
            stopwatch1.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopwatch1.Stop();
            TimeSpan ts0 = stopwatch0.Elapsed;
            TimeSpan ts1 = stopwatch1.Elapsed;
            Console.WriteLine($"Время работы String = {ts0}, время работы StringBuilder = {ts1}.");
        }
    }
}
