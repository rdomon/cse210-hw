// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Person myPerson = new Person("Bob", "Bubba", 97);

        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        PoliceMan myPoliceMan = new PoliceMan("Taser", "Joe", "Mamma", 32);
        Console.WriteLine($"{myPoliceMan.DisplayPoliceManInfo()}");
        Console.WriteLine($"{myPoliceMan.DisplayPersonInfo()}");
    }
}