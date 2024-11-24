using System;
using System.Collections.Generic;

namespace ScriptureApp
{
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
}
