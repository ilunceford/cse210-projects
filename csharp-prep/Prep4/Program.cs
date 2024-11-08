using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "0")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid number or 'done' to finish.");
            }
        }

        if (numbers.Count > 0)
        {
            // Calculate the sum
            int sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");

            // Calculate the average
            double average = numbers.Average();
            Console.WriteLine($"Average: {average}");

            // Find the maximum number
            int max = numbers.Max();
            Console.WriteLine($"Maximum: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
