namespace MethodsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods\n");

            // Objects
            int prodsTotal = Product.TotalNoProducts;

            Product productA = new Product();
            prodsTotal++;
            Product productB = new Product();
            prodsTotal++;

            // Product A
            int prodAID = productA.productID = 1001;
            string prodAName = productA.productName = "Electric Heater";
            double prodACost = productA.cost = 235.245D;

            productA.CalculateTax();
            double prodAtaxAmount = productA.tax;
            int prodAQuantity = productA.quantityInStock = 245;
            string prodACat = Product.CategoryName;
            string prodADate = productA.dateOfPurchase;

            // Product B
            int prodBID = productB.productID = 1002;
            string prodBName = productB.productName = "LED TV";
            double prodBCost = productB.cost = 587.345D;

            productB.CalculateTax();
            double prodBtaxAmount = productB.tax;
            int prodBQuantity = productB.quantityInStock = 1257;
            string prodBCat = Product.CategoryName;

            string prodBDate = productB.dateOfPurchase;


            // Outputs
            Console.WriteLine("Product 1");
            Console.WriteLine($"Product ID: {prodAID}");
            Console.WriteLine($"Product Name: {prodAName}");
            Console.WriteLine($"Product Cost: {prodACost:C2}");
            Console.WriteLine($"Tax Amount: {prodAtaxAmount:C}");

            Console.WriteLine($"Product Quantity in stock: {prodAQuantity}");
            Console.WriteLine($"Product Category: {prodACat}");
            Console.WriteLine($"Product Date of Purchase: {prodADate}");
            Console.WriteLine($"Product ID: {prodAID}\n");

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


/**
 *   public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;
 */