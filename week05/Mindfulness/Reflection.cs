class Reflection : Activity
{
    private string[] _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    private string[] _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    ];

    public Reflection()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        DisplayStartMessage();

        LoadActivity();

        Refelect();

        DisplayEndMessage();
    }

    private void Refelect()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomItem(_prompts)} ---");
        Console.Write("\nWhen you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("\nNow ponder the following questions:");
        Console.Write("You may begin in: ");

        Countdown(3);

        Console.WriteLine("\n");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine($"> {GetRandomItem(_questions)}");
            Spinner(5);
            Console.WriteLine();
        }
    }

    private string GetRandomItem(string[] list)
    {
        return list[new Random().Next(list.Length)];
    }
}