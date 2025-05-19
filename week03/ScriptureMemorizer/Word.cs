class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public override string ToString() => _isHidden
        ? new string('_', _text.Length)
        : _text;

    public void Hide() => _isHidden = true;
    
    public bool IsHidden() => _isHidden;
}