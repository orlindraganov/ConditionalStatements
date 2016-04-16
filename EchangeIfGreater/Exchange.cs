using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int firstValue = int.Parse(Console.ReadLine());
        int secondValue = int.Parse(Console.ReadLine());

        if (firstValue < secondValue)
        {
            Console.WriteLine("{0} {1}", firstValue, secondValue);
        }
        else
            Console.WriteLine("{1} {0}", firstValue, secondValue);
    }
}
