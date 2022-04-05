using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           datatypes
        string myName = "razaq";
        int numOne = 6;
        double balanceToday = 9.45;
        long moniMe = 675644444440998;
        bool MyBool = True;
        char myLetter = 'D';
        float myFloat = 5.78;
        decimal myDecimal = 77.88;
        short myShort = 17;
        uint ui = 56;

        // implicit and explicit conversions
        // implicit conversion
        int i = 75;
        long j = i;

        // explicit conversion
        double d = 56.88;
        int myInt = (int) d;
        Console.WriteLine(myInt);


        }
    }
}
