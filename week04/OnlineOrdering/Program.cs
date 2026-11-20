using System;

class Program
{
    static void Main(string[] args)
    {
        Address firstAddress = new Address("12 Opal Street", "Seattle", "Washington", "United States of America");
        Customer firstCustomer = new Customer("Alex Morgan", firstAddress);
        Product batteries = new Product("AAA batteries", 4.52, 3);
        Product buckets = new Product("20L buckets", 3.75, 5);
        Product foil = new Product("aluminium foil", 2.83, 2);
        List<Product> firstProducts = [batteries, buckets, foil];
        Order firstOrder = new Order(firstProducts, firstCustomer);

        Address secondAddress = new Address("9th Avenue", "Toronto", "Ontario", "Canada");
        Customer secondCustomer = new Customer("Ben Smith", secondAddress);
        Product speaker = new Product("bluetooth speaker", 95.99, 1);
        Product microphone = new Product("Wired microphone", 25.40, 3);
        List<Product> secondProducts = [speaker, microphone];
        Order secondOrder = new Order(secondProducts, secondCustomer);

        Console.WriteLine(firstOrder.GetPackagingLabel());
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine($"\nTotal cost: {firstOrder.CalculateTotal()}\n");

        Console.WriteLine(secondOrder.GetPackagingLabel());
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine($"\nTotal cost: {secondOrder.CalculateTotal()}");
    }
}