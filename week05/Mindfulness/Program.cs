// Creativity: I added a counter to keep track of how many activities the user completed.

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breating activity");
            Console.WriteLine("\t2. Start reflection activity");
            Console.WriteLine("\t3. Start lisiting activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Breathing();
                    count++;
                    break;
                case "2":
                    new Reflection();
                    count++;
                    break;
                case "3":
                    new Listing();
                    count++;
                    break;
                default:
                    running = false;
                    break;
            }

            Console.WriteLine($"\nThank you for taking time for your mind! You completed {count} activities!");
        }
    }
}