using System;

class PointInACircleAndRect
{
    static void Main()
    {
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());

        if (((x < -1.5) | (x > 1.5)) || ((y < -1.5) | (x > 1.5)))
        {
            Console.WriteLine("Point ({0},{1}) is outside circle K({1, 1}, 1.5)", x, y);
        }
        else
        {
            Console.WriteLine("Point ({0},{1}) is inside circle K({1, 1}, 1.5)", x, y);
        }
        if (((y < 1) | (x < -1)) || ((x > -1 + 6) | (y > 1 + 2)))
        {
            Console.WriteLine("Point ({0},{1}) is outside rectangle R(top=1, left=-1, width=6, height=2).", x, y);
        }
        else
        {
            Console.WriteLine("Point ({0},{1}) is inside rectangle R(top=1, left=-1, width=6, height=2).", x, y);
        }
    }
}
