using GeometryLibrary.Core.Interfaces;

namespace GeometryLibrary.Core.Utils;

public static class ShapeCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}