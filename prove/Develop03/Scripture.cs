using System;
using System.Collections.Generic;

namespace ScriptureMemorization;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord(int count)
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }

    public void HideAllWords()
    {
        foreach (var word in _words)
        {
            word.Hide();
        }
    }
    public string GetDisplay()
    {
        string displayText = _reference.GetDisplay() + " ";
        foreach (var word in _words)
        {
            displayText += word.GetDisplay() + " ";
        }
        return displayText.Trim();
    }
}