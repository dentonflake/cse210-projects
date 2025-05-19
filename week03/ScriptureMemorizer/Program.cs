// Denton Flake
// Creativity: I added a score that gets displayed when the user quits.

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture(
            new Reference("Alma", 26, 12),
            "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God, for in his strength I can do all things; yea, behold, many mighty miracles we have wrought in this land, for which we will praise his name forever."
        );

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture);

            Console.Write("\nPress enter to continue or type 'quit' to finish: ");

            if (Console.ReadLine() == "quit" || scripture.Score() == 0)
            {
                Console.WriteLine($"You finished with {scripture.Score()} words left. Good job!");

                break;
            }

            scripture.Hide(3);
        }
    }
}