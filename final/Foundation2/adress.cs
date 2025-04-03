using System.Net.Sockets;

public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Is the address in USA?
    public bool IsUSA()
    {
        return country.ToUpper() == "USA";
    }

    // Full address as a string
    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {state}\n{country}";
    }
}