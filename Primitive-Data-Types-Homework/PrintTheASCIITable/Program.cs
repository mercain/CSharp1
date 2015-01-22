using System;

class PrintTheASCIITable
{
    static void Main()
    {
        char temp;
        string buffer = "";
        for (int i = 0; i < 127; i++)
        {
            temp = (char)i;
            buffer += temp;
        }
        Console.WriteLine(buffer);
    }
}
