using System;

class Program
{
    static void Main()
    {
        Address customerAddress=new Address("123 Yo Mamma's House", "None-ya", "Business", "USA");
        
        Customer customer=new Customer ("Gary-Stu", customerAddress);

        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Deviled Egg", "Z001DB3RG", 1000000m, 1);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Order Cost: ${order.CalculateTotalCost}");
    }
}