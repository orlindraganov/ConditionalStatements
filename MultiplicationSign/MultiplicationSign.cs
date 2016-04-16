﻿using System;
using System.Globalization;
using System.Threading;


class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
            Console.WriteLine("0");
        else if ((firstNumber > 0) ^ (secondNumber > 0) ^ (thirdNumber > 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

    }
}
