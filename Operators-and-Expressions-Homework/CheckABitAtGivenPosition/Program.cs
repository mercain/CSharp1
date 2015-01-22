using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Bit position to check: ");
        int p = int.Parse(Console.ReadLine());
       
        int m = 1 << p;
        int r = (n & m) >> p;

        bool result = r == 1;

        Console.WriteLine("Bit at position {0} in Number {1}(binary: {2}) = 1?\nResult: {3}", p, n, Convert.ToString(n, 2).PadLeft(32, '0'), result.ToString());
    }
}

