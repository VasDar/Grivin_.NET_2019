using System;


namespace Task03
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ISeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);
            Console.WriteLine();
            Console.WriteLine(list[3]);
            Console.WriteLine();
            Console.WriteLine(progression[5]);
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

        public interface ISeries : IIndexable
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
}


