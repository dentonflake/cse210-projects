using System;

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
                break;

            scripture.Hide(3);
        }
    }
}
