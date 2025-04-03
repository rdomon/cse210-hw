using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // activities
        Running running = new Running("2025-04-03", 30, 3.0);
        Cycling cycling = new Cycling("2025-04-05", 45, 15.0);
        Swimming swimming = new Swimming("2025-04-07", 20, 20);

        // put in the same list
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        // loop the list
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("-------------------------------");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}