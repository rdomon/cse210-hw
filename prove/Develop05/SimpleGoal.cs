// Simple Goal
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public override void RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
        }
    }

    public override string GetDisplayStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Points},{IsCompleted}";
    }

    public static SimpleGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        SimpleGoal goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
        goal.IsCompleted = bool.Parse(parts[3]);
        return goal;
    }
}
