using ClassLibrary1;
public class Program
{
    static void Main(string[] args)
    {
        //Product product1, product2, product3;

        // Initialize objects
        Product product1 = new Product();
        Product product2 = new Product();
        Product product3 = new Product();

        // Initialize fields with values
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;

        product3.productID = 1003;
        product3.productName = "Speaker";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        double totalCost = product1.cost + product2.cost + product3.cost;

        // Calculate the highest cost
        double highestCost = 0;

        if (product1.cost > highestCost)
        {
            highestCost = product1.cost;
        }
        else if (product2.cost > highestCost)
        {
            highestCost = product2.cost;
        }
        else
        {
            highestCost = product3.cost;
        }
        Console.WriteLine($"Total cost = {totalCost}");
        Console.WriteLine($"Highest cost = {highestCost}");
    }
}
