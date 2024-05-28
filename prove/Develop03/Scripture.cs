using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Verse> _verses;

    public Scripture(Reference reference, List<Verse> verses)
    {
        _reference = reference;
        _verses = verses.Where(v => _reference.IsWithinRange(v.VerseNumber)).ToList();
    }

    public string GetReferenceText()
    {
        return _reference.GetReference();
    }

    public string GetScriptureText()
    {
        return string.Join("\n", _verses.Select(verse => verse.GetVerseText()));
    }

    public void Display()
    {
        Console.WriteLine($"{GetReferenceText()}\n{GetScriptureText()}");
    }

    public bool ObscureRandomWords(int numberOfWords)
    {
        bool anyUnobscured = _verses.Any(verse => !verse.AllWordsObscured());

        if (!anyUnobscured) return false;

        int wordsToObscure = numberOfWords;
        while (wordsToObscure > 0 && anyUnobscured)
        {
            foreach (var verse in _verses)
            {
                if (wordsToObscure <= 0) break;
                if (!verse.AllWordsObscured())
                {
                    if (verse.ObscureRandomWords(1))
                    {
                        wordsToObscure--;
                    }
                }
            }
            anyUnobscured = _verses.Any(verse => !verse.AllWordsObscured());
        }

        return anyUnobscured;
    }
}