public class Product
{
    private string Name { get; set; }
    private string ProductId { get; set; }
    private double PricePerUnit { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }

    public string GetProductInfo()
    {
        return $"{Name} (ID: {ProductId})";
    }
}
