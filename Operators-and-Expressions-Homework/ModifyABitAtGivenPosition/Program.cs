using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int m;
        int r;
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a position ot modify: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a value(0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        if ((v < 0) | (v > 1))
        {
            Console.WriteLine("Invalid value");
        }
        else
        {
            if (v == 0)
            {
                m = ~(1 << p);
                r = (n & m);
            }
            else
            {
                m = v << p;
                r = (n | m);
            }       
            Console.WriteLine("Result: {0}", r);
        }

    }
}
