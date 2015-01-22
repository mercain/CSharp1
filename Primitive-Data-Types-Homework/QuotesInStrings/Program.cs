using System;

class Program
{
    static void Main()
    {
        string strOne = @"The ""use"" of quotations causes difficulties.";
        string strTwo = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}", strOne, strTwo);
    }
}

