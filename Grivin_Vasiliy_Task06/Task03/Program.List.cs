﻿namespace Task03
{
    partial class Program
    {
        public class List : ISeries, IIndexable
        {
            private double[] series;
            private int currentIndex;

            public List(double[] series)
            {
                this.series = series;
                currentIndex = 0;
            }

            public double GetCurrent()
            {
                return series[currentIndex];
            }

            public bool MoveNext()
            {
                currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
                return true;
            }

            public void Reset()
            {
                currentIndex = 0;
            }

            public double this[int index]
            {
                get { return series[index]; }
            }
        }
    }
}


