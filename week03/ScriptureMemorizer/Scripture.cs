class Scripture
{
    private string _reference = "Alma 26:12";
    private string _contents = "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever.";
    private List<int> _hidden = new List<int>();

    public void Display()
    {
        Console.Clear();

        List<string> words = _contents.Split(" ").ToList();

        Console.Write($"{_reference} ");

        for (int i = 0; i < words.Count; i++)
        {
            if (_hidden.Contains(i))
            {
                Console.Write(new string('_', words[i].Length) + " ");
            }
            else
            {
                Console.Write(words[i] + " ");
            }
        }
    }

    public void Hide(int count)
    {
        List<string> words = _contents.Split(" ").ToList();

        Random random = new Random();

        while (count > 0 && _hidden.Count < words.Count)
        {
            int index = random.Next(words.Count);
            
            if (!_hidden.Contains(index))
            {
                _hidden.Add(index);
                count--;
            }
        }
    }
}