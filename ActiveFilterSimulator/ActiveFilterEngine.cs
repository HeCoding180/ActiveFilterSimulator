using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part;

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
        public ComplexPartTreeEngine ZaTreeEngine;
        public ComplexPartTreeEngine ZbTreeEngine;

        public ActiveFilterEngine()
        {
            ZaTreeEngine = new ComplexPartTreeEngine();
            ZbTreeEngine = new ComplexPartTreeEngine();
        }
        public ActiveFilterEngine(ComplexPartTreeEngine zaTreeEngine, ComplexPartTreeEngine zbTreeEngine)
        {
            ZaTreeEngine = zaTreeEngine;
            ZbTreeEngine = zbTreeEngine;
        }

        public double getGainAt(double frequency)
        {
            return 1 + ZaTreeEngine.getComplexImpedance(frequency).z / ZbTreeEngine.getComplexImpedance(frequency).z;
        }
        public double getPhaseAt(double frequency)
        {
            return ZbTreeEngine.getComplexImpedance(frequency).theta - ZaTreeEngine.getComplexImpedance(frequency).theta;
        }
    }

    public class FilterIterator
    {
        public int fStart { set; get; }
        public int fStop { set; get; }
        public double fIncrement { set; get; }

        public FilterIterator(int start, int stop, double increment)
        {
            if (start > stop)
                throw new ArgumentException("stop must be higher than start");
            if ((10.0f % increment) != 0)
                throw new ArgumentException("invalid increment value");

            fStart = start;
            fStop = stop;
            fIncrement = increment;
        }

        public List<graphPoint> getImpedancePlot(ComplexPartTreeEngine partTreeEngine)
        {
            List<graphPoint> ImpedancePlot = new List<graphPoint>();

            for (int fDecade = fStart; fDecade <= fStop; fDecade *= 10)
            {
                for (double fDecadeOffset = 1; fDecadeOffset <= (10 - fIncrement); fDecadeOffset += fIncrement)
                {
                    graphPoint point = new graphPoint();
                    point.x = (int)(fDecade * fDecadeOffset);
                    point.y = partTreeEngine.getComplexImpedance(fDecade * fDecadeOffset).z;
                    ImpedancePlot.Add(point);
                }
            }

            return ImpedancePlot;
        }
        public List<graphPoint> getImpedancePhasePlot(ComplexPartTreeEngine partTreeEngine)
        {
            List<graphPoint> PhasePlot = new List<graphPoint>();

            for (int fDecade = fStart; fDecade <= fStop; fDecade *= 10)
            {
                for (double fDecadeOffset = 1; fDecadeOffset <= (10 - fIncrement); fDecadeOffset += fIncrement)
                {
                    graphPoint point = new graphPoint();
                    point.x = (int)(fDecade * fDecadeOffset);
                    point.y = partTreeEngine.getComplexImpedance(fDecade * fDecadeOffset).theta * 180 / Math.PI;
                    PhasePlot.Add(point);
                }
            }

            return PhasePlot;
        }

        public List<graphPoint> getGainPlot(ActiveFilterEngine filterEngine)
        {
            List<graphPoint> GainPlot = new List<graphPoint>();

            for (int fDecade = fStart; fDecade <= fStop; fDecade *= 10)
            {
                for (double fDecadeOffset = 1; fDecadeOffset <= (10 - fIncrement); fDecadeOffset += fIncrement)
                {
                    graphPoint point = new graphPoint();
                    point.x = (int)(fDecade * fDecadeOffset);
                    point.y = filterEngine.getGainAt(fDecade * fDecadeOffset);
                    GainPlot.Add(point);
                }
            }

            return GainPlot;
        }

        public List<graphPoint> getPhasePlot(ActiveFilterEngine filterEngine)
        {
            return getPhasePlot(filterEngine, phaseUnit.DEG);
        }
        public List<graphPoint> getPhasePlot(ActiveFilterEngine filterEngine, phaseUnit unit)
        {
            List<graphPoint> PhasePlot = new List<graphPoint>();

            //outputMultiplier is used for setting the unit of the phase shift 
            double outputMultiplier = 1.0f;
            if (unit == phaseUnit.DEG) outputMultiplier = 180 / Math.PI;

            for (int fDecade = fStart; fDecade <= fStop; fDecade *= 10)
            {
                for (double fDecadeOffset = 1; fDecadeOffset <= (10 - fIncrement); fDecadeOffset += fIncrement)
                {
                    graphPoint point = new graphPoint();
                    point.x = (int)(fDecade * fDecadeOffset);
                    point.y = filterEngine.getPhaseAt(fDecade * fDecadeOffset) * outputMultiplier;
                    PhasePlot.Add(point);
                }
            }

            return PhasePlot;
        }
    }
}
