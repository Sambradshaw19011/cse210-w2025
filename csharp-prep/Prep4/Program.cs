using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_number;

        while (true)
        {
            Console.Write("Add a new number (type 0 to stop): ");
            new_number = int.Parse(Console.ReadLine());

            if (new_number == 0)
            {
                break;
            }

            numbers.Add(new_number);

            Console.WriteLine("\nCurrent list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        Console.WriteLine("\nFinal list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
