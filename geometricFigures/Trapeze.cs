using System;
namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d; 
        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
        }
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }
        private double ValidateD(double d)
        {
            if (d <= 0) throw new ArgumentException("Side D must be greater than zero.");
            return d;
        }
        public override double GetArea() => ((B + D) * H) / 2;
        public override double GetPerimiter() => A + B + C + D;
    }
}