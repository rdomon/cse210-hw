using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers (type 0 when finished): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

        // adding numbers if it's not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        // AVERAGE
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is:{average}");


        // MAX
        int max = numbers[0];

        foreach  (int number in numbers)
        {
            if(number > max)
            {
                // new max
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}