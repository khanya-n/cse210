public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        CreateID();
    }

    private void CreateID()
    {
        Random random = new Random();
        _id = random.Next(1000, 10000);
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}