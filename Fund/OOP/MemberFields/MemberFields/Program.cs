using Employee;

namespace MemberFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productsTotal = Product.totalNoProducts;
            string category = Product.CatergoryName;

            // Initialize objects
            Product product1 = new Product();
            productsTotal++;
            Product product2 = new Product();
            productsTotal++;
            Product product3 = new Product();
            productsTotal++;

            Customer customer1 = new Customer();

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
            if (product2.cost > highestCost)
            {
                highestCost = product2.cost;
            }
            if (product3.cost > highestCost)
            {
                highestCost = product3.cost;
            }

            // Set expiry date for all products
            int prodOneExp = product1.expDate;
            Console.WriteLine(prodOneExp);
            prodOneExp = 2030;

            // Date of Purchase 
            string prodOneDateOfPurchase = product1.dateOfPurchase;

            // Outputs
            Console.WriteLine($"Total cost = {totalCost}");
            Console.WriteLine($"Highest cost = {highestCost}");

            customer1.customerID = 1001;
            Console.WriteLine(customer1.customerID);
            Console.WriteLine($"Total number of products: {productsTotal}");
            Console.WriteLine($"Category for all products is: {category}");

            Console.WriteLine($"Product one expiry date: {prodOneExp}");
            Console.WriteLine($"Product One Date of Purchase: {prodOneDateOfPurchase}");
        }
    }
}
