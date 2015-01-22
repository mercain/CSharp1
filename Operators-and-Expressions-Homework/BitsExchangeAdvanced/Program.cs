using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter start position: ");
        int posStart = int.Parse(Console.ReadLine());
        Console.Write("Enter end position: ");
        int posEnd = int.Parse(Console.ReadLine());
        Console.Write("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            n = ReplaceBit(n, posStart, posEnd);
            posStart += 1;
            posEnd += 1;
        }
        Console.WriteLine("Result number: {0}", n);
    }

    static int GetBit(uint num, int pos)
    {
        int m = 1 << pos;
        uint r = (uint)(num & m) >> pos;
        return (int)r;
    }

    static uint SetBit(uint num, int pos, int value)
    {
        uint m;
        if (value == 0)
        {
            m = ~((uint)1 << pos);
            return (num & m);
        }
        else
        {
            m = (uint)1 << pos;
            return (num | m);
        }
    }

    static uint ReplaceBit(uint num, int fromPos, int toPos)
    {
        uint maskNum;
        maskNum = SetBit(num, toPos, GetBit(num, fromPos));
        maskNum = SetBit(maskNum, fromPos, GetBit(num, toPos));
        return maskNum;
    }
}