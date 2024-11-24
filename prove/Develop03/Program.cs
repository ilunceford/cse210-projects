using System;

namespace ScriptureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptureLibrary library = new ScriptureLibrary();
            Scripture selectedScripture = library.GetRandomScripture();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(selectedScripture);

                if (selectedScripture.IsFullyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Well done!");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                selectedScripture.HideRandomWords();
            }
        }
    }
}
