using System;

class Program
{
    static void Main(string[] args)
    {
        // addresses
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Park Avenue", "NewYork City", "NY", "USA");
        Address address3 = new Address("789 Beach Road", "Coastal City", "FL", "USA");

        // different types of events
        Lecture lecture = new Lecture("Programming Fundamentals", "Learn the basics of C# programming", "2025-04-10", "10:00 AM", address1, "Brother. John Smith", 50);
        
        Reception reception = new Reception("Networking Mixer", "Connect with industry professionals", "2025-05-20", "6:00 PM", address2, "rsvp@gmail.com");
        
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Annual company picnic at the park", "2025-07-10", "12:00 PM", address3, "Sunny with a high of 75°F");

        // display info of each event
        Console.WriteLine("\n=== Lecture Event ===");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\n=== Reception Event ===");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\n=== Outdoor Gathering Event ===");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}