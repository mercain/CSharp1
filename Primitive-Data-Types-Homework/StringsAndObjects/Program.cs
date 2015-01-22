using System;

class StringsAndObjects
{
    static void Main()
    {
        string strOne = "Hello";
        string strTwo = "World";
        object objOne = strOne + '\u0020' + strTwo;
        string strThree = (string)objOne;
        Console.WriteLine(strThree);
    }
}
