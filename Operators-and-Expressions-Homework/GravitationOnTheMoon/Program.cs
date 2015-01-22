using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        double weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the moon will be: {0} kg", (weight * 17) / 100);
    }
}
