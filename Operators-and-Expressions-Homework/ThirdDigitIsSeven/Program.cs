using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        if (number[number.Length - 3] == '7')
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
