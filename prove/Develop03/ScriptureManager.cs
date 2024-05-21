using System;
using System.Collections.Generic;

class ScriptureManager
{
    private List<Scripture> _scriptures;

    public ScriptureManager()
    {
        _scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
}