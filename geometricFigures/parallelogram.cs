using System;
namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
          H = h;
        }
        public double H
        {
          get => _h;
          set => _h = ValidateH(value);
        }
        private double ValidateH(double h)
        {
          if (h <= 0) throw new ArgumentException("Height H must be greater than zero.");
          return h;
        }
        // Formula from PDF: Area = B * H
        public override double GetArea() => B * H;
        // Formula from PDF: Perimeter = 2 * (A + B)
        public override double GetPerimiter() => 2 * (A + B);
    }
}