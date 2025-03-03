using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    public static int AddNumbers(int x, int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("Hello CSE 210 World!");
        // Console.WriteLine("Please enter your name:");
        // string name = Console.ReadLine();
        // Console.WriteLine($"{name}");


        // int x = 10;

        // if(x != 10 && x!= 20 || x != 20 && x != 30)
        // {
        //     Console.WriteLine("X is not 10");
        // }

        // else if (x == 10)
        //     Console.WriteLine("In the else statement");


        // int x = 10;
        // int y = ++x;
        // int z = y;

        // Console.WriteLine($"{x},{y},{z}");


        // For loop
        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"{i}: Bob");
        // }

        // List
        // List<int>numbers = new List<int>(1,2,3,4,5,6,7,8);
        // numbers.Add(10);

        // // For each loop
        // foreach(int x in numbers)
        // {
        //     Console.WriteLine($"x");
        // }

        // while loop
        // bool correctInput = false;
        // while(!correctInput)
        // {
        //     Console.Write("please input your age");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age < 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        // }


        // do while loop
        // bool correctInput;
        // do
        // {
        //     Console.Write("please input your age");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age < 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        //     else
        //         correctInput = false;
        // }while(!correctInput);



        // // Random
        // Random newRandomNumber = new Random();
        // for(int i = 0; i < 100; i++)
        // {
        //     int number = newRandomNumber.Next(1,1000);
        //     Console.WriteLine($"{i}: {number}");
        // }


        int total = AddNumbers(100,200);
        Console.WriteLine($"{total}");


    }
}