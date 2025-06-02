class Listing : Activity
{
    private string[] _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        DisplayStartMessage();

        LoadActivity();

        List();

        DisplayEndMessage();
    }

    private void List()
    {
        Console.WriteLine("\nList the responses to the following prompt:\n");
        Console.WriteLine($"--- {GetRandomItem(_prompts)} ---");

        Console.Write("You may begin in: ");

        Countdown(3);

        Console.WriteLine();
        Console.WriteLine("\nStart listing... (press Enter after each item)");

        List<string> responses = new();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write(">");

            string item = Console.ReadLine();

            responses.Add(item);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
    }

    private string GetRandomItem(string[] list)
    {
        return list[new Random().Next(list.Length)];
    }
}