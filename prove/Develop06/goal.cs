public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points}";
    }
}
