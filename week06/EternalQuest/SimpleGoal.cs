public class SimpleGoal : Goal
{
    private bool _completed = false;

    public SimpleGoal(string name, string description, int points, bool completed = false)
        : base(name, description, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _completed;

    public override string GetStatus() => _completed ? "[X]" : "[ ]";

    public override string GetSaveData()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_completed}";
    }
}