using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveFilterSimulator
{
    public enum phaseUnit
    {
        DEG,
        RAD
    }

    public enum filterType
    {
        HP,
        LP,
        BP
    }

    public struct graphPoint
    {
        public int x;
        public double y;
    }

    public class ActiveFilterEngine
    {
        public ActiveFilterEngine(filterType fType)
        {

        }

        public static double getGainAt(double frequency)
        {

        }
        public static double getPhaseAt(double frequency)
        {

        }
    }

    public class FilterIterator
    {
        public int fStart { set; get; }
        public int fStop { set; get; }
        public double fIncrement { set; get; }

        public FilterIterator(int start, int stop, double increment)
        {
            if (start < stop)
                throw new ArgumentException("start must be higher than stop");
            if ((10.0f % increment) != 0)
                throw new ArgumentException("invalid increment value");
        }

        public graphPoint[] getGainPlot(ActiveFilterEngine filterEngine)
        {

        }

        public graphPoint[] getPhasePlot(ActiveFilterEngine filterEngine)
        {
            return getPhasePlot(filterEngine, phaseUnit.DEG);
        }
        public graphPoint[] getPhasePlot(ActiveFilterEngine filterEngine, phaseUnit unit)
        {
            int arrayPoints = (int)(10.0f / fIncrement * Math.Log10(fStop / fStart));
            graphPoint[] PhasePlot = new graphPoint[arrayPoints];

            double outputMultiplier = 1.0f;
            if (unit == phaseUnit.DEG) outputMultiplier = 180 / Math.PI;

            int index = 0;
            for (int fDecade = fStart; fDecade <= fStop; fDecade *= 10)
            {
                for (double fDecadeOffset = 1; fDecadeOffset < (10 - fIncrement); fDecadeOffset += fIncrement)
                {
                    PhasePlot[index].x = (int)(fDecade * fDecadeOffset);
                    PhasePlot[index].y = filterEngine.getPhaseAt(fDecade * fDecadeOffset);
                    index++;
                }
            }
        }
    }
}
