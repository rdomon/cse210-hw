// チェックリスト目標 (指定回数完了するタイプ)
public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
    {
        Name = name;
        Points = points;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordProgress()
    {
        CurrentCount++;
        
        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
        }
    }

    public override string GetDisplayStatus()
    {
        return $"Completed {CurrentCount}/{TargetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{TargetCount},{BonusPoints},{CurrentCount}";
    }

    public static ChecklistGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        ChecklistGoal goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), 
                                               int.Parse(parts[3]), int.Parse(parts[4]));
        goal.CurrentCount = int.Parse(parts[5]);
        return goal;
    }
}