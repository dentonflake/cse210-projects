using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Menu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");

        string response =  Console.ReadLine();

        if (response == "1")
            AddEntry();
        else if (response == "2")
            Display();
        else if (response == "3")
            Load();
        else if (response == "4")
            Save();
        else
            Environment.Exit(0);
    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.New();

        _entries.Add(entry);

        Menu();
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        Menu();
    }

    public void Load()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry {
                _date = parts[0],
                _prompt = parts[1],
                _response = parts[2]
            };

            _entries.Add(entry);
        }

        Menu();
    }

    public void Save()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }

        Menu();
    }
}