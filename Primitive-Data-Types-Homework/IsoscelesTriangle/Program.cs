using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        string triangle = string.Format("   {0}\n  {0} {0}\n {0} {0} {0}\n{0} {0} {0} {0}", copyRight);
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine(triangle);
    }
}
