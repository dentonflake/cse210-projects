public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _prompt;
    public string _response;
    public List<string> _prompts = new List<string>
    {
        "Describe a time when you felt truly happy.",
        "What is something you are grateful for today?",
        "Write about a challenge you overcame recently.",
        "What is a goal you want to achieve this week?",
        "Describe a place that makes you feel at peace.",
        "What is a lesson you learned recently?",
        "Write about someone who inspires you and why.",
        "What is a memory that makes you smile?",
        "Describe something new you tried recently.",
        "What is a habit you want to improve or develop?"
    };

    public void New()
    {
        _date = getDate();
        _prompt = getRandomPrompt();
        _response = getResponse(_prompt);
    }

    public string getDate()
    {
        DateTime today = DateTime.Now;
        return today.ToShortDateString();
    }

    public string getRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string getResponse(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write(">");
        return Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}\n");
    }
}