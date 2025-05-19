class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string contents)
    {
        _reference = reference;
        _words = contents.Split(" ")
            .Select(w => new Word(w))
            .ToList();
    }

    public override string ToString()
    {
        string scripture = "";


        scripture += _reference;
        scripture += " ";

        foreach (Word word in _words)
        {
            scripture += word;
            scripture += " ";
        }

        return scripture;
    }

    public void Hide(int count)
    {
        Random random = new Random();
        
        List<int> visibleIndexes = _words
            .Select((word, index) => new { word, index })
            .Where(x => !x.word.IsHidden())
            .Select(x => x.index)
            .ToList();

        for (int i = 0; i < count && visibleIndexes.Count > 0; i++)
        {
            int randomIndex = random.Next(visibleIndexes.Count);
            _words[visibleIndexes[randomIndex]].Hide();
            visibleIndexes.RemoveAt(randomIndex);
        }
    }

    public int Score() => _words.Count(word => !word.IsHidden());
}