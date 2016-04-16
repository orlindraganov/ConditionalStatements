using System;

class BonusScore

{
    static void Main()
    {
        long score = long.Parse(Console.ReadLine());
        if ((0 < score) && (score < 10))
        {
            if ((1 <= score) && (score <= 3))
            {
                score *= 10;
            }
            if ((4 <= score) && (score <= 6))
            {
                score *= 100;
            }
            if ((7 <= score) && (score <= 9))
            {
                score *= 1000;
            }
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
