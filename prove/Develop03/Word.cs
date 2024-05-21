using System;

class Word
{
    private string _word;
    private bool _isObscured;

    public Word(string word)
    {
        _word = word;
        _isObscured = false;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsObscured()
    {
        return _isObscured;
    }

    public void Obscure()
    {
        _isObscured = true;
    }
}