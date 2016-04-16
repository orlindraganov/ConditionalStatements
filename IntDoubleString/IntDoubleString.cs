using System;
using System.Globalization;
using System.Threading;



class IntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string type = Console.ReadLine();
        if (type == "integer")
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input + 1);
        }
        else if (type == "real")
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F}", (input + 1D));
        }
        else if (type == "text")
        {
            string input = Console.ReadLine();
            Console.WriteLine(input + "*");
        }
    }
}
