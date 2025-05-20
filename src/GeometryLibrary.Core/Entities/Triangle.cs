using System;
using GeometryLibrary.Core.Interfaces;

namespace GeometryLibrary.Core.Entities;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IShape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }
    
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Triangle"/>.
    /// </summary>
    /// <param name="a">Сторона A. Должна быть положительной.</param>
    /// <param name="b">Сторона B. Должна быть положительной.</param>
    /// <param name="c">Сторона C. Должна быть положительной.</param>
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
    
    /// <summary>
    /// Вычисляет площадь треугольника.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double CalculateArea()
    {
        var s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));    
    }
    
    /// <summary>
    /// Вычисляет площадь треугольника.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public bool IsRightAngled()
    {
        var sides = new[] { A, B, C };
        Array.Sort(sides);
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
    }
}