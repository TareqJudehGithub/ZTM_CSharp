namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation\n");

            // Objects           

            Product productA = new Product();
            Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

            Product productB = new Product();
            Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

            Product productC = new Product();
            Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

            int productTotal = Product.GetTotalNoProducts();

            // Product A
            productA.SetProductID(1001);
            int productAID = productA.GetProductID();

            productA.SetProductName("Electric Heater");
            string prodAName = productA.GetProductName();

            productA.SetCost(235.245D);
            double prodACost = productA.GetCost();

            productA.CalculateTax(cost: prodACost);
            productA.CalculateTax(cost: prodACost, percentage: 10);
            double prodAtaxAmount = productA.GetTax();


            productA.SetQuantityInStock(245);
            int prodAQuantity = productA.GetQuantityInStock();

            string prodACat = productA.GetCategoryName();
            string prodADate = productA.GetDateOfPurchase();

            // Product B
            productB.SetProductID(1002);
            int prodBID = productB.GetProductID();

            productB.SetProductName("LED TV");
            string prodBName = productB.GetProductName();

            productB.SetCost(587.345D);
            double prodBCost = productB.GetCost();

            productB.CalculateTax(cost: prodBCost);
            productB.CalculateTax(cost: prodBCost, percentage: 15);
            double prodBtaxAmount = productB.GetTax();

            productB.SetQuantityInStock(1257);
            int prodBQuantity = productB.GetQuantityInStock();

            productC.SetQuantityInStock(475);
            int prodCQuantity = productC.GetQuantityInStock();
            // Total of products in stock
            int TotalInStock = Product.GetTotalQuantity(product1: productA, product2: productB, product3: productC);

            string prodBCat = productB.GetCategoryName();

            string prodBDate = productB.GetDateOfPurchase();

            // Outputs
            Console.WriteLine("Product 1");
            Console.WriteLine($"Product ID: {productAID}");
            Console.WriteLine($"Product Name: {prodAName}");
            Console.WriteLine($"Product Cost: {prodACost:C2}");
            Console.WriteLine($"Tax Amount: {prodAtaxAmount:C}");

            Console.WriteLine($"Product Quantity in stock: {prodAQuantity}");
            Console.WriteLine($"Product Category: {prodACat}");
            Console.WriteLine($"Product Date of Purchase: {prodADate}\n");

            Console.WriteLine("Product 2");
            Console.WriteLine($"Product ID: {prodBID}");
            Console.WriteLine($"Product Name: {prodBName}");
            Console.WriteLine($"Product Cost: {prodBCost:C2}");
            Console.WriteLine($"Tax Amount: {prodBtaxAmount:C}");

            Console.WriteLine($"Product Quantity in stock: {prodBQuantity}");
            Console.WriteLine($"Product Category: {prodBCat}");
            Console.WriteLine($"Product Date of Purchase: {prodBDate}\n");

            Console.WriteLine($"Total amount in stock for all products: {TotalInStock}");
            Console.WriteLine($"Product Total: {productTotal}");
        }
    }
}
