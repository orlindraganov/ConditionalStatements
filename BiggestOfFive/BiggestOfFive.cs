using System;
using System.Globalization;
using System.Threading;


class BiggestOfFive
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double? number = null;
        double? biggestNumber = null;


        for (int i = 0; i < 5; i++)
        {
            number = double.Parse(Console.ReadLine());
            if ((number >= biggestNumber) || (biggestNumber == null))
            {
                biggestNumber = number;
            }
        }
        Console.WriteLine(biggestNumber);
    }
}
