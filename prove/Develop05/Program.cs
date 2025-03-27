// Main Program

public class EternalQuestProgram
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public void Run()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\n--- Eternal Quest ---");
        Console.WriteLine($"Current Score: {_totalScore}");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Goal Event");
        Console.WriteLine("3. List Goals");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Select an option: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points per event: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    private void RecordGoalEvent()
    {
        DisplayGoals();
        Console.Write("Enter the goal number to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            selectedGoal.RecordProgress();
            
            // 点数の計算をここでする：）
            _totalScore += selectedGoal.Points;
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.CurrentCount == checklistGoal.TargetCount)
            {
                _totalScore += checklistGoal.BonusPoints;
                Console.WriteLine($"Bonus points earned: {checklistGoal.BonusPoints}");
            }

            Console.WriteLine($"Recorded event for: {selectedGoal.Name}");
            Console.WriteLine($"Points earned: {selectedGoal.Points}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void DisplayGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayStatus()} {_goals[i].Name}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _totalScore = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            Goal loadedGoal = parts[0] switch
            {
                "SimpleGoal" => SimpleGoal.CreateFromString(lines[i]),
                "EternalGoal" => EternalGoal.CreateFromString(lines[i]),
                "ChecklistGoal" => ChecklistGoal.CreateFromString(lines[i]),
                _ => null
            };

            if (loadedGoal != null)
            {
                _goals.Add(loadedGoal);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();
        program.Run();
    }
}