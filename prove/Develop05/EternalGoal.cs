// Eternal Goal
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordProgress()
    {
        // 常に目標は完了していない
        IsCompleted = false;
    }

    public override string GetDisplayStatus()
    {
        return "[ ]"; // 永遠の目標は常に未完了にする
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Points}";
    }

    public static EternalGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        return new EternalGoal(parts[1], int.Parse(parts[2]));
    }
}