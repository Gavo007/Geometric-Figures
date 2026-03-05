using System;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b; 
        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
        {
          B = b;
        }
        public double B
        {
          get => _b;
          set => _b = ValidateB(value);
        }
        private double ValidateB(double b)
        {
          if (b <= 0) throw new ArgumentException("Side B must be greater than zero.");
          return b;
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimiter() => 2 * (A + B);
    }
}
