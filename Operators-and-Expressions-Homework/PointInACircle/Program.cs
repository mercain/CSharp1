using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());
        if ( ( (x < -2) | (x > 2)) || ((y < -2) | (x > 2))) //if (a or b) and (a or b)
        {
            Console.WriteLine("Point is outside circle");
        }
        else
        {
            Console.WriteLine("Point is inside circle");
        }
    }
}
