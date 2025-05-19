using GeometryLibrary.Core.Interfaces;

namespace GeometryLibrary.Core.Entities;

public class Triangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
    
    public Triangle(double a, double b, double c)
    {
        if (a  <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("All sides must be positive");
        
        double[] sides = [a, b, c];
        Array.Sort(sides);
        if (sides[0] + sides[1] <= sides[2])
            throw new ArgumentException("Triangle inequality violated");

        A = a;
        B = b;
        C = c;
    }
    
    public double CalculateArea()
    {
        var s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));    
    }
    
    public bool IsRightAngled()
    {
        var sides = new[] { A, B, C };
        Array.Sort(sides);
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
    }
}