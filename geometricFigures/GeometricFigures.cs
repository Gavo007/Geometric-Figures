public abstract class GeometricFigure
{
    public string Name { get; set; }
    public abstract double GetArea();
    // we use the name of the diagram
    public abstract double GetPerimiter();
    public override string ToString()
    {
        return $"{Name}\n" +
         $"=> Area.....: {GetArea():N5}\n" +
         $"=> Perimiter: {GetPerimiter():N5}\n";
    }
}
