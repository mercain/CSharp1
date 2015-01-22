using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle perimeter is: {0}, and it's area is: {1}", (width * 2) + (height * 2), width * height);
    }
}

