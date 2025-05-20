using GeometryLibrary.Core.Interfaces;

namespace GeometryLibrary.Core.Utils;

/// <summary>
/// Класс для вычисления площади фигуры.
/// </summary>
public static class ShapeCalculator
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <param name="shape">Фигура.</param>
    /// <returns>Площадь фигуры.</returns>
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}