using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.New();

        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
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
    }
}