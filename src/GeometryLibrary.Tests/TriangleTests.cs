using GeometryLibrary.Core.Entities;
using Xunit;

namespace GeometryLibrary.Tests;

public class TriangleTests
{
    [Fact]
    public void Area_ValidTriangle_ReturnsCorrect()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 2);
    }

    [Fact]
    public void IsRightAngled_ValidTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}