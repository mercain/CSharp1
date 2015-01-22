using System;

class ComparingFloats
{
    static void Main()
    {
        double ebs = 0.000001;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (ebs >= (a - b))
        {
            Console.WriteLine("Equal at precision 0.000001");
        }
        else
        {
            Console.WriteLine("Not eqael");
        }
    }
}

