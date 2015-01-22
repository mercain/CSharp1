using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Replacing bits 3, 4 and 5 with 24, 25 and 26 of number {0}\nBinary: {1}\n", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        n = ReplaceBit(n, 3, 24);
        n = ReplaceBit(n, 4, 25);
        n = ReplaceBit(n, 5, 26);
        Console.WriteLine("Result number: {0}\nBinary: {1}\n", n, Convert.ToString(n, 2).PadLeft(32, '0'));
    }

    static int GetBit(int num, int pos)
    {
        int m = 1 << pos;
        int r = (num & m) >> pos;
        return r;
    }

    static int SetBit(int num, int pos, int value)
    {
        int m;
        if (value == 0)
        {
            m = ~(1 << pos);
            return (num & m);
        }
        else
        {
            m = 1 << pos;
            return (num | m);
        }     
    }

    static int ReplaceBit(int num, int fromPos, int toPos)
    {
        int maskNum;
        maskNum = SetBit(num, toPos, GetBit(num, fromPos));
        maskNum = SetBit(maskNum, fromPos, GetBit(num, toPos));
        return maskNum;
    }
}
