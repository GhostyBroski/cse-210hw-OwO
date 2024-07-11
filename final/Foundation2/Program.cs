using System;

public class Program
{
    public static void Menu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Orders");
            Console.WriteLine("2. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayOrders();
                    break;
                case "2":
                    Console.WriteLine("Quitting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void DisplayOrders()
    {
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPLabel());
            Console.WriteLine(order.GetSLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
        }
    }

    private static List<Order> orders = new List<Order>();

    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Shelbyville", "IN", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Widget A", "A001", 9.99m, 2);
        Product product2 = new Product("Widget B", "B001", 19.99m, 1);
        Product product3 = new Product("Widget C", "C001", 5.99m, 3);

        Product product4 = new Product("Gadget X", "X001", 14.99m, 1);
        Product product5 = new Product("Gadget Y", "Y001", 29.99m, 2);

        Order order1 = new Order(customer1);
        order1.AddItem(product1);
        order1.AddItem(product2);
        order1.AddItem(product3);

        Order order2 = new Order(customer2);
        order2.AddItem(product4);
        order2.AddItem(product5);

        orders.Add(order1);
        orders.Add(order2);

        Menu();
    }
}