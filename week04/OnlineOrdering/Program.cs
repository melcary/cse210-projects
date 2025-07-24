using System;
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.SetName("Laptop");
        product1.SetProductId("P100");
        product1.SetPrice(999.99);
        product1.SetQuantity(1);

        Product product2 = new Product();
        product2.SetName("Mouse");
        product2.SetProductId("P101");
        product2.SetPrice(19.99);
        product2.SetQuantity(2);

        Address usaAddress = new Address();
        usaAddress.SetStreet("123 Main St");
        usaAddress.SetCity("New York");
        usaAddress.SetState("NY");
        usaAddress.SetCountry("USA");

        Customer usaCustomer = new Customer();
        usaCustomer.SetName("John Smith");
        usaCustomer.SetAddress(usaAddress);

        Order order1 = new Order();
        order1.SetCustomer(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Product product3 = new Product();
        product3.SetName("Keyboard");
        product3.SetProductId("P205");
        product3.SetPrice(49.99);
        product3.SetQuantity(1);

        Product product4 = new Product();
        product4.SetName("Monitor");
        product4.SetProductId("P201");
        product4.SetPrice(299.99);
        product4.SetQuantity(1);

        Product product5 = new Product();
        product5.SetName("HDMI cable");
        product5.SetProductId("P210");
        product5.SetPrice(12.50);
        product5.SetQuantity(3);

        Address internationalAddress = new Address();
        internationalAddress.SetStreet("456 Los Riscos");
        internationalAddress.SetCity("Lima");
        internationalAddress.SetState("Molina");
        internationalAddress.SetCountry("Peru");

        Customer internationalCustomer = new Customer();
        internationalCustomer.SetName("Maria Lopez");
        internationalCustomer.SetAddress(internationalAddress);

        Order order2 = new Order();
        order2.SetCustomer(internationalCustomer);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOtal cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost():0.00}");
    }
}