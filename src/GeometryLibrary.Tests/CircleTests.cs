using GeometryLibrary.Core.Entities;
using Xunit;

namespace GeometryLibrary.Tests;

public class CircleTests
{
    [Fact]
    public void Area_CorrectRadius_ReturnsCorrect()
    {
        var circle = new Circle(1);
        Assert.Equal(Math.PI, circle.CalculateArea(), 2);
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}