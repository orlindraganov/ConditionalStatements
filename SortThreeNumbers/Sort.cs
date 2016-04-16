using System;

class Sort
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber))
        {
            Console.Write(firstNumber + " ");
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + secondNumber);
            }
        }
        else if ((secondNumber >= firstNumber) && (secondNumber >= thirdNumber))
        {
            Console.Write(secondNumber + " ");
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + firstNumber);
            }
        }
        else
        {
            Console.Write(thirdNumber + " ");
            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber + " " + secondNumber);
            }
            else
            {
                Console.WriteLine(secondNumber + " " + firstNumber);
            }
        }
    }
}
