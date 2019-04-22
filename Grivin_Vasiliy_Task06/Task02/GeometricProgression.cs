
using System;

namespace Task02
{
    public class GeometricProgression : ISeries
    {
        double startB1, stepQ;
        int currentIndex;

        public GeometricProgression(double startB1, double stepQ)
        {
            this.startB1 = startB1;
            this.stepQ = stepQ;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return startB1 * Math.Pow(stepQ, currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }


    }
}
