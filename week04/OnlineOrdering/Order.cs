public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total;
    }

    public string GetPackagingLabel()
    {
        string label = "ID\tName\tQuantity\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetID()}\t{product.GetName()}\t{product.GetQuantity()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()}\n{_customer.GetAddress()}";
    }
}