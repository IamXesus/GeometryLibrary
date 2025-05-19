using GeometryLibrary.Core.Entities;
using GeometryLibrary.Core.Interfaces;

namespace ConsoleApp;

public static class Program
{
    public static void Main()
    {
        IShape shape1 = new Circle(5);
        IShape shape2 = new Triangle(3, 4, 5);
        
        var circleArea = shape1.CalculateArea();
        var triangleArea = shape2.CalculateArea();
        
        Console.WriteLine($"The area of the circle is {circleArea}");
        Console.WriteLine($"The area of the triangle is {triangleArea}");

        if (shape2 is Triangle triangle && triangle.IsRightAngled())
        {
            Console.WriteLine("Triangle is right-angled.");
        }
    }
}