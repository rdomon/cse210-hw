public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // add product
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // calculate total cost of order
    public double GetTotalCost()
    {
        double totalCost = 0;
        
        // Add up cost of all products
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        
        // Add shipping cost based on customer location
        double shippingCost = customer.IsUSA() ? 5 : 35;
        totalCost += shippingCost;
        
        return totalCost;
    }

    // get packing label
    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL:\n";
        
        foreach (var product in products)
        {
            packingLabel += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        
        return packingLabel;
    }

    // get shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL:\n";
        shippingLabel += $"Customer: {customer.GetName()}\n";
        shippingLabel += customer.GetAddress().GetFullAddress();
        
        return shippingLabel;
    }
}