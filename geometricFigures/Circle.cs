using System;
namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        private double _r; 
        public Circle(string name, double r)
        {
          Name = name;
          R = r; 
        }
        public double R
        {
          get => _r;
          set => _r = ValidateR(value); 
        }
        private double ValidateR(double r)
        {
          if (r <= 0) throw new ArgumentException("El radio debe ser mayor a cero");
          return r;
        }
        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        public override double GetPerimiter() => 2 * Math.PI * R;
    }
}
