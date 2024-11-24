using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureApp
{
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
}
