public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        int earned = 0;
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            earned += _points;
            if (_currentCount == _targetCount)
            {
                earned += _bonusPoints;
            }
        }
        return earned;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() => $"[{(_currentCount >= _targetCount ? "X" : " ")}] Completed {_currentCount}/{_targetCount} times";

    public override string GetSaveData()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
    }
}