using System;
using System.Collections.Generic;

namespace MindfulnessApp.Activities
{
    public class ListingActivity : Activity
    {
        private readonly List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "What are things you are grateful for?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() 
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

        protected override void PerformActivity(int duration)
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);

            Console.WriteLine("Start listing items:");

            DateTime endTime = DateTime.Now.AddSeconds(duration);
            List<string> items = new List<string>();

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"You listed {items.Count} items!");
        }
    }
}
