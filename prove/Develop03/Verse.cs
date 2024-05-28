using System;
using System.Collections.Generic;

class Verse
{
    private List<Word> _words;
    public int VerseNumber { get; private set; }

    public Verse(int verseNumber, string verseText)
    {
        VerseNumber = verseNumber;
        _words = verseText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetVerseText()
    {
        return string.Join(' ', _words.Select(word => word.IsObscured() ? new string('_', word.GetWord().Length) : word.GetWord()));
    }

    public bool ObscureRandomWords(int numberOfWords)
    {
        Random random = new Random();
        var unobscuredWords = _words.Where(word => !word.IsObscured()).ToList();
        if (unobscuredWords.Count == 0) return false;

        for (int i = 0; i < numberOfWords && unobscuredWords.Count > 0; i++)
        {
            int index = random.Next(unobscuredWords.Count);
            unobscuredWords[index].Obscure();
            unobscuredWords.RemoveAt(index);
        }
        return unobscuredWords.Count > 0;
    }

    public bool AllWordsObscured()
    {
        return _words.All(word => word.IsObscured());
    }
}