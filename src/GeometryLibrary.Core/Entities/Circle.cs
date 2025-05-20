using System;
using GeometryLibrary.Core.Interfaces;

namespace GeometryLibrary.Core.Entities;

/// <summary>
/// Круг
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Радиус круга.
    /// </summary>
    private double Radius { get;}

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Circle"/>.
    /// </summary>
    /// <param name="radius">Радиус круга. Должен быть положительным.</param>
    /// <exception cref="ArgumentException">Если радиус <= 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero");
        Radius = radius;
    }
    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public double CalculateArea() => Math.PI * Radius * Radius;
}