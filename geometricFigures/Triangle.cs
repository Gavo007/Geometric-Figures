namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c; 
        private double _h; 
        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
          C = c;
          H = h;
        }
        public double C
        {
          get => _c;
          set => _c = ValidateC(value);
        }
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }
        private double ValidateC(double c)
        {
          if (c <= 0) throw new ArgumentException("Side C must be greater than zero.");
          return c;
        }
        private double ValidateH(double h)
        {
          if (h <= 0) throw new ArgumentException("Height H must be greater than zero.");
          return h;
        }
        public override double GetArea() => (B * H) / 2;
        public override double GetPerimiter() => A + B + C;
    }
}
