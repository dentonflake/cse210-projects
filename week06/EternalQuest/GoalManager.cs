public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private List<string> _badges = new List<string>();

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void RecordGoalEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");

            CheckLevelUp();
            CheckBadges();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 Congratulations! You've reached LEVEL {_level}! 🎉");
        }
    }

    private void CheckBadges()
    {
        if (_score >= 1000 && !_badges.Contains("Bronze Badge"))
        {
            _badges.Add("Bronze Badge");
            Console.WriteLine("🏅 You earned the Bronze Badge! (1000 points)");
        }
        if (_score >= 5000 && !_badges.Contains("Silver Badge"))
        {
            _badges.Add("Silver Badge");
            Console.WriteLine("🏅 You earned the Silver Badge! (5000 points)");
        }
        if (_score >= 10000 && !_badges.Contains("Gold Badge"))
        {
            _badges.Add("Gold Badge");
            Console.WriteLine("🏅 You earned the Gold Badge! (10000 points)");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nCurrent score: {_score}");
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine("Badges: " + (_badges.Count > 0 ? string.Join(", ", _badges) : "None"));
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveData());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool completed = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, completed));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int targetCount = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);
                    int currentCount = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, currentCount));
                }
            }

            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}