using System;
namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        public Square(string name, double a)
        {
          Name = name;
          A = a;
        }
        public double A
        {
          get => _a;
          set => _a = ValidateA(value);
        }
        private double ValidateA(double a)
        {
          if (a <= 0) throw new ArgumentException("Side A must be greater than zero.");
          return a;
        }
        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimiter() => 4 * A;
    }
}