public class Product
{
    // Fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    public double tax;

    #region Constructors 
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
    #endregion

    #region Methods
    // Write a problem (method) to calculate tax
    // Tax = 10% if the cost is less or equal than $20k, and it is 12.5% if the cost is > 20k

    //public double CalculateTax()
    //{
    //    double taxAmount;

    //    if (cost <= 500)
    //    {
    //        tax = 0.12;
    //        taxAmount = cost * tax;
    //    }
    //    else
    //    {
    //        tax = 0.125;
    //        taxAmount = cost * tax;
    //    }
    //    Console.WriteLine($"Tax percenage = {tax}");
    //    return taxAmount;
    //}
    public void CalculateTax()
    {
        double taxAmount;

        if (cost <= 500)
        {
            tax = 0.12;
            taxAmount = cost * tax;
        }
        else
        {
            tax = 0.125;
            taxAmount = cost * tax;
        }
        tax = taxAmount;
    }
    #endregion

}