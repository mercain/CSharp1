using System;

class BitwiseExtractBitNumberThree
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0}: {1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));
        uint m = 1 << 3;
        uint r = ((n & m) >> 3);
        Console.WriteLine("Third bit is: {0}", r);
    }
}
