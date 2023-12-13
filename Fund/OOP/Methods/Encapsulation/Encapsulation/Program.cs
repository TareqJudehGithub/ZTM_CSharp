namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation\n");

            // Objects
            int prodsTotal = Product.TotalNoProducts;

            Product productA = new Product();
            prodsTotal++;
            Product productB = new Product();
            prodsTotal++;

            // Product A
            productA.SetProductID(1001);
            int productAID = productA.GetProductID();

            productA.SetProductName("Electric Heater");
            string prodAName = productA.GetProductName();

            productA.SetCost(235.245D);
            double prodACost = productA.GetCost();

            productA.CalculateTax();
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

            productB.CalculateTax();
            double prodBtaxAmount = productB.GetTax();

            productB.SetQuantityInStock(1257);
            int prodBQuantity = productB.GetQuantityInStock();

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

            Console.WriteLine($"Product Total: {prodsTotal++}");

        }
    }
}
