class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected void DisplayStartMessage()
    {
        Console.Clear();

        Console.WriteLine(_name + "\n");
        Console.WriteLine(_description + "\n");

        Console.Write("How long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou completed {_duration} seconds of the {_name}.");

        Spinner(5);
    }

    protected void LoadActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}