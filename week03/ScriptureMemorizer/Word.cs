public class Word
{
    // Attributes
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Accessors
    public string GetText()
    {
        return _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    // Mutators
    public void SetText(string text)
    {
        _text = text;
    }

    public void SetHidden(bool hidden)
    {
        _isHidden = hidden;
    }

    // Class Functions
    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}