using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 1)
        {
            Console.WriteLine("Number is odd");
        }
        else
        {
            Console.WriteLine("Number is even");
        }
    }
}
