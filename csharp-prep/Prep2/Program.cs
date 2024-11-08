using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade < 60)
        {
            Console.WriteLine("You failed and received an F.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You Failed and recieved a D.");
        }
        else if (grade < 80)
        {
            Console.WriteLine("You passed with a C.");
        }
        else if (grade < 90)
        {
            Console.WriteLine("You passed with a B.");
        }
        else
        {
            Console.WriteLine("Great job! You passed with an A.");
        }
    }
}
