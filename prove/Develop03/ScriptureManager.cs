using System;
using System.Collections.Generic;

class ScriptureManager
{
    private List<Scripture> _scriptures;

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public Scripture GetScripture(Reference reference)
    {
        return _scriptures.FirstOrDefault(s => s.GetReferenceText() == reference.GetReference());
    }

    public ScriptureManager()
    {
        _scriptures = new List<Scripture>();
    }
}