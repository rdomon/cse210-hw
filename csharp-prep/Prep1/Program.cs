using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name?");
        string firstname = Console.ReadLine();

        Console.WriteLine("What's your last name?");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname}, {lastname}.");
    }
}