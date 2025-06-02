class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breating Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        DisplayStartMessage();

        LoadActivity();

        Breathe();

        DisplayEndMessage();
    }

    private void Breathe()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.WriteLine();
            
            Console.Write("\nNow breathe out... ");
            Countdown(3);
            Console.WriteLine();
        }
    }
}