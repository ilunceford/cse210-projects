public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[" + (IsComplete() ? "X" : " ") + $"] {_shortName} ({_amountCompleted}/{_target} completed, {_points} points each, {_bonus} bonus)";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_target}|{_bonus}|{_amountCompleted}";
    }
}
