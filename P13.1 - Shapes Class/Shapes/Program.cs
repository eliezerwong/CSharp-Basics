//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.length = 4;
            rectangle1.width = 5;
            Console.WriteLine($"Rect1 area: {rectangle1.CalculateArea()}");
            Console.WriteLine($"Rect1 pari: {rectangle1.CalculatePerimeter()}");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.length = 10;
            rectangle2.width = 12;
            Console.WriteLine($"Rect2 area: {rectangle2.CalculateArea()}");
            Console.WriteLine($"Rect2 pari: {rectangle2.CalculatePerimeter()}");

            Circle circle1 = new Circle();
            circle1.radius = 5;
            Console.WriteLine($"Circle1 area: {circle1.CalculateArea()}");
            Console.WriteLine($"Circle1 pari: {circle1.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.radius = 10;
            Console.WriteLine($"Circle2 area: {circle2.CalculateArea()}");
            Console.WriteLine($"Cirlce2 pari: {circle2.CalculatePerimeter()}");

            Console.ReadKey();
        }
    }
}
