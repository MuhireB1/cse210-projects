using System;
using System.Collections.Generic;

public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Accessor
    public Reference GetReference()
    {
        return _reference;
    }

    // Mutator
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    // Class Functions
    public void HideRandomWords(int count)
    {
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }

        return true;
    }
}