using System;

class PrimeNumberCheck
{
    static void Main()
    {
        bool check = true;
        Console.Write("Enter a number to check: ");
        int num = int.Parse(Console.ReadLine());

        if ((num > 1) && (num <= 100))
        {
            for (int i = 2; i < 100; i++)
            {
                if (i != num)
                {
                    if (num % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check)
            {
                Console.WriteLine("Number is Prime.");
            }
            else
            {
                Console.WriteLine("Number is not Prime.");
            }
        }
    }
}