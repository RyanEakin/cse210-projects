using System.Drawing;

class Word {
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show() // good rule of thumb for setters... only one variable is set!
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string displayText;

        if (IsHidden() == true)
        {
            displayText = "_".PadRight(_text.Length,'_');
        }
        else
        {
            displayText = _text;
        }

        return displayText;
    }
}