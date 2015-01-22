using System;

class FourDigitNumber
{
    static void Main()
    {
        int sum = 0;
        Console.Write("Please enter a 4 digit number: ");
        string num = Console.ReadLine();
        if (num.Length == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                sum += int.Parse(num[i].ToString());
            }
            Console.WriteLine("Sum of {0} digits: {1}", num, sum);
            Console.WriteLine("Reversed digits: {3}{2}{1}{0}", num[0], num[1], num[2], num[3]);
            Console.WriteLine("Last digit in the first position: {3}{0}{1}{2}", num[0], num[1], num[2], num[3]);
            Console.WriteLine("Exchanges the second and the third digits: {0}{2}{1}{3}", num[0], num[1], num[2], num[3]);
        }
        else
        {
            Console.WriteLine("Number must be 4 digits!");
        }
    }
}
