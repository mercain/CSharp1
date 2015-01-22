using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Smith";
        byte age = 90;
        char gender = 'M';
        long pIDNum = 8306112507;
        int uniNum = 27569999;
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}",
            firstName, lastName, age, gender, pIDNum, uniNum);
    }
}