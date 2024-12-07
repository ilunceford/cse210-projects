namespace MindfulnessApp.Activities
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

        protected override void PerformActivity(int duration)
        {
            int cycleTime = 6; 
            int cycles = duration / cycleTime;

            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(3);
                Console.WriteLine("Breathe out...");
                ShowCountdown(3);
            }
        }

        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
