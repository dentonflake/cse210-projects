using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Order order1 = new Order
        (
            new Customer
            (
                "John Doe",

                new Address
                (
                    "123 Fake St",
                    "Sun Valley",
                    "Colorado",
                    68432,
                    "United States"
                )
            ),

            new List<Product>()
            {
                new Product
                (
                    64398,
                    "Hotdogs",
                    1.5,
                    7
                ),

                new Product
                (
                    78403,
                    "Chips",
                    2.46,
                    2
                ),

                new Product
                (
                    840932,
                    "Grapes",
                    0.98,
                    2
                )
            }
        );

        Order order2 = new Order
        (
            new Customer
            (
                "Jane Doe",

                new Address
                (
                    "Rua das Flores, 321",
                    "Belo Horizonte",
                    "Minas Gerais",
                    30140,
                    "Brazil"
                )
            ),

            new List<Product>()
            {
                new Product
                (
                    11122,
                    "Soda",
                    1.25,
                    6
                ),

                new Product
                (
                    33344,
                    "Pizza Rolls",
                    3.99,
                    3
                ),

                new Product
                (
                    55566,
                    "Ice Cream",
                    4.75,
                    1
                )
            }
        );

        Console.WriteLine("Order 1:\n====================================\n");
        Console.WriteLine($"Packing Label: \n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order1.GetShippingLabel()}");
        Console.WriteLine($"Order Total: \n${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2:\n====================================\n");
        Console.WriteLine($"Packing Label: \n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order2.GetShippingLabel()}");
        Console.WriteLine($"Order Total: \n${order2.GetTotalCost()}\n");
    }
}