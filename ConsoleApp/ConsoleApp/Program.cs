namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder productBuilder = new();
            Product product = productBuilder
                .SetName("Product A")
                .SetDescription("This is Product A")
                .SetPrice(9.99m)
                .SetQuantity(10)
                .Build();

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(product, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
        }
    }
}