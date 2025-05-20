using GeometryLibrary.Core.Entities;
using GeometryLibrary.Core.Utils;
using GeometryLibrary.Core.Interfaces;

class Program
{
    static void Main()
    {
        // Пример 1: Работа с кругом
        try
        {
            IShape circle = new Circle(5);
            Console.WriteLine($"Площадь круга: {ShapeCalculator.CalculateArea(circle):F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        // Пример 2: Работа с треугольником
        try
        {
            IShape triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника: {ShapeCalculator.CalculateArea(triangle):F2}");

            if (triangle is Triangle t && t.IsRightAngled())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        // Пример 3: Некорректный треугольник
        try
        {
            IShape invalidTriangle = new Triangle(1, 2, 3);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}