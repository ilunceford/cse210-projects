using System;
using System.Threading;

namespace MindfulnessApp.Activities
{
    public abstract class Activity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Starting the {Name}...");
            Console.WriteLine($"{Description}");
            Console.Write("Enter the duration of the activity in seconds: ");
            int duration = int.Parse(Console.ReadLine() ?? "30");
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
            PerformActivity(duration);
            Finish(duration);
        }

        protected abstract void PerformActivity(int duration);

        private void Finish(int duration)
        {
            Console.WriteLine("\nGood job! You completed the activity.");
            ShowSpinner(3);
            Console.WriteLine($"You have completed the {Name} for {duration} seconds.");
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
