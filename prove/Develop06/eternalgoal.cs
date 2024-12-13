public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals never end
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are for lifetime.
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_points} points, Eternal)";
    }
}
