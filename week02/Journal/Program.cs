using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
                journal.AddEntry();
            else if (choice == "2")
                journal.Display();
            else if (choice == "3")
                journal.Load();
            else if (choice == "4")
                journal.Save();
            else
                break;

        } while (true);
    }
}