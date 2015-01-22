using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? numOne = null;
        double? numTwo = null;
        Console.WriteLine("{0} {1}", numOne, numTwo);
        numOne = 1;
        numTwo = 1.5;
        Console.WriteLine("{0} {1}", numOne, numTwo);
    }
}
