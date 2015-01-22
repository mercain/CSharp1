using System;

class ExtractBiFromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Position: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0}: {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        int m = 1 << p;
        int r = (n & m) >> p;

        Console.WriteLine("{0} bit is: {1}", p, r);
    }
}
