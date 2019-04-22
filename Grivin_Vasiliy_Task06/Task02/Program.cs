
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries arithmeticProgression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(arithmeticProgression);

            ISeries geometricProgression = new GeometricProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(geometricProgression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }

    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    public interface IIndexable
    {
        double this[int index] { get; }
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }
}
