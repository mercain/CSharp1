using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Trapezoid area calculator");
        Console.Write("Side A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Side B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid area is: {0}", (((a + b) * h) / 2));
    }
}