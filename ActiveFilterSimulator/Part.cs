using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part
{
    public delegate complexNumber getComplexPropertyMethod(double partValue, double frequency);

    public class InvalidOperationException : Exception
    {
        public InvalidOperationException(string msg) : base(msg)
        {

        }
    }

    public class ScientifficValue
    {
        public double BareValue { set; get; }
        public int ValueScientiffic { set; get; }

        public ScientifficValue(double value, int Scientiffic)
        {
            BareValue = Math.Round(value, 3); //Round the value to an arbitary amount of digits to prevent data storage inaccuracy error (x.999999... and x.000000...1)
            ValueScientiffic = Scientiffic;
        }

        public static ScientifficValue ParseValueToScientifficValue(double Value)
        {
            if (Value == 0.0f)
            {
                return new ScientifficValue(0, 0);
            }
            else
            {
                int scientiffic = ((int)Math.Log10(Value)) - (((int)Math.Log10(Value)) % 3);
                double bareVal = Value / Math.Pow(10, scientiffic);
                return new ScientifficValue(bareVal, scientiffic);
            }
        }
        public double constructValue()
        {
            return BareValue * Math.Pow(10, ValueScientiffic);
        }
    }

    public class complexNumber
    {
        private double _R { set; get; }
        private double _i { set; get; }
        private double _z { set; get; }
        private double _theta { set; get; }

        public double R
        {
            set
            {
                _R = value;
                _z = pythagoricTheorem(_R, _i);
                _theta = Math.Atan2(_i, _R);
            }
            get
            {
                return _R;
            }
        }
        public double i
        {
            set
            {
                _i = value;
                _z = pythagoricTheorem(_R, _i);
                _theta = Math.Atan2(_i, _R);
            }
            get
            {
                return _i;
            }
        }
        public double z
        {
            set
            {
                _z = value;
                _R = Math.Abs(_z) * Math.Cos(_theta);
                _i = Math.Abs(_z) * Math.Sin(_theta);
            }
            get
            {
                return _z;
            }
        }
        public double theta
        {
            set
            {
                _theta = value;
                _R = Math.Abs(_z) * Math.Cos(_theta);
                _i = Math.Abs(_z) * Math.Sin(_theta);
            }
            get
            {
                return _theta;
            }
        }

        public complexNumber()
        {
            R = 0.0f;
            i = 0.0f;
        }
        public complexNumber(double Real, double Imaginary)
        {
            R = Real;
            i = Imaginary;
        }

        public static complexNumber splitZ(double z, double theta)
        {
            return new complexNumber(Math.Abs(z) * Math.Cos(theta), Math.Abs(z) * Math.Sin(theta));
        }

        public static double pythagoricTheorem(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public static complexNumber reciprocal(complexNumber a)
        {
            return new complexNumber(a.R / (Math.Pow(a.R, 2) + Math.Pow(a.i, 2)), a.i / (Math.Pow(a.R, 2) + Math.Pow(a.i, 2)));
        }

        public static complexNumber operator +(complexNumber a, complexNumber b)
        {
            return new complexNumber(a.R + b.R, a.i + b.i);
        }
        public static complexNumber operator -(complexNumber a, complexNumber b)
        {
            return new complexNumber(a.R - b.R, a.i - b.i);
        }
        public static complexNumber operator *(complexNumber a, complexNumber b)
        {
            return new complexNumber(a.R * b.R - a.i * b.i, a.R * b.i + a.i * b.R);
        }
        public static complexNumber operator /(complexNumber a, complexNumber b)
        {
            return a * reciprocal(b);
        }
    }

    public class ComplexPart
    {
        //public Attributes
        public getComplexPropertyMethod ResistivePropertyFunction { set; get; }
        public double PartValue { set; get; }
        public double frequency { set; get; }

        public complexNumber ComplexResistiveProperty
        {
            get
            {
                return ResistivePropertyFunction(PartValue, frequency);
            }
        }

        public ComplexPart(getComplexPropertyMethod propertyMethod)
        {
            ResistivePropertyFunction = propertyMethod;
            PartValue = 0;
        }
        public ComplexPart(getComplexPropertyMethod propertyMethod, double value)
        {
            ResistivePropertyFunction = propertyMethod;
            PartValue = value;
        }
    }

    public class RealPart
    {
        public static double omega(double frequency)
        {
            return 2 * Math.PI * frequency;
        }

        public static complexNumber resistance(double partValue, double frequency)
        {
            return new complexNumber(partValue, 0.0f);
        }
        public static complexNumber inductiveReactiance(double partValue, double frequency)
        {
            double reactance = omega(frequency) * partValue;
            return new complexNumber(0.0f, reactance);
        }
        public static complexNumber capacitiveReactiance(double partValue, double frequency)
        {
            double reactance = -(1 / (omega(frequency) * partValue));
            return new complexNumber(0.0f, reactance);
        }
    }
}
