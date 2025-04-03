public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Does the customer live in USA?
    public bool IsUSA()
    {
        return address.IsUSA();
    }

    // Get name
    public string GetName()
    {
        return name;
    }

    // Get address
    public Address GetAddress()
    {
        return address;
    }
}