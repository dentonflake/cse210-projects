// Denton Flake
// Creativity: I added a score that gets displayed when the user quits.

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        while (true)
        {
            scripture.Display();

            Console.Write("\n\nPress enter to continue or 'quit' to finish: ");

            if (Console.ReadLine() == "quit")
            {
                int score = scripture.Score();

                Console.Write($"\nYou finished with {score} words remaining. Good job!");

                break;
            }

            scripture.Hide(3);
        }
    }
}
