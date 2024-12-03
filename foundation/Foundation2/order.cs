using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += Customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"- {product.GetProductInfo()}\n";
        }
        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.GetCustomerInfo()}";
    }
}
