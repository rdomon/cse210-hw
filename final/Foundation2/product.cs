public class Product
{
    private string name;
    private string productId;
    private double pricePerUnit;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    // Method to calculate total cost for this product
    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    // Get name
    public string GetName()
    {
        return name;
    }

    // Get product ID
    public string GetProductId()
    {
        return productId;
    }
}