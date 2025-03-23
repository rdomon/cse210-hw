using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        
        bool quit = false;
        Dictionary<string, int> activityStats = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflection Activity", 0 },
            { "Listing Activity", 0 }
        };
        
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityStats["Breathing Activity"]++;
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    activityStats["Reflection Activity"]++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityStats["Listing Activity"]++;
                    break;
                case "4":
                    DisplayStats(activityStats);
                    break;
                case "5":
                    quit = true;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
    
    static void DisplayStats(Dictionary<string, int> stats)
    {
        Console.Clear();
        Console.WriteLine("Activity Statistics");
        Console.WriteLine("------------------");
        foreach (var activity in stats)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value} times");
        }
        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
    }
}