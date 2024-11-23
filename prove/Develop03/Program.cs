using System;
using System.Collections.Generic;
using System.Linq;

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

class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}"
            : $"{Book} {Chapter}:{StartVerse}";
    }
}

class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Any())
        {
            var random = new Random();
            var wordsToHide = visibleWords.OrderBy(_ => random.Next()).Take(count);

            foreach (var word in wordsToHide)
            {
                word.Hide();
            }
        }
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        string text = string.Join(" ", Words);
        return $"{Reference}\n{text}";
    }
}

class ScriptureLibrary
{
    private List<Scripture> Scriptures { get; set; }

    public ScriptureLibrary()
    {
        Scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };
    }

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return Scriptures[random.Next(Scriptures.Count)];
    }
}
