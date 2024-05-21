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
        if (!_isObscured)
        {
            _word = new string('_', _word.Length);
            _isObscured = true;
        }
    }
}