using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the score");
        int score = int.Parse(Console.ReadLine());
        if (score >= 90)
        {
            Console.Write("A");
        }
        else if (score >= 80)
        {
            Console.Write("B");
        }
        else if (score >= 70)
        {
            Console.Write("C");
        }
        else if (score >= 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }
    }
}