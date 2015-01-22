using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter a number to check: ");
        int num = int.Parse(Console.ReadLine());
        if (((num % 7) == 0) && ((num % 5) == 0))
        {
            Console.WriteLine("Number is divisible.");
        }
        else
        {
            Console.WriteLine("Number is not divisible.");
        }
    }
}
