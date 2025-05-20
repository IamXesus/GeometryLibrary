namespace GeometryLibrary.Core.Interfaces;

/// <summary>
/// Интерфейс для геометрических фигур.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double CalculateArea();
}