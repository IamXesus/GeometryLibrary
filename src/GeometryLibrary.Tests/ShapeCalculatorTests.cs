using GeometryLibrary.Core.Entities;
using GeometryLibrary.Core.Interfaces;
using GeometryLibrary.Core.Utils;
using Xunit;

namespace GeometryLibrary.Tests;

public class ShapeCalculatorTests
{
    [Fact]
    public void CalculateArea_AnyShape_ReturnsCorrect()
    {
        //Не совсем понятно из задания - должен ли быть какой-то интерфейс для ввода данных
        //поэтому указал их сам
        IShape circle = new Circle(2);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.Equal(Math.PI * 4, ShapeCalculator.CalculateArea(circle), 2);
        Assert.Equal(6, ShapeCalculator.CalculateArea(triangle), 2);
    }
}