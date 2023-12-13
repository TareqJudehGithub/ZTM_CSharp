public class Product
{
    #region Fields
    // Fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;
    public double tax;
    #endregion

    #region Properties
    // productID
    public void SetProductID(int value)
    {
        productID = value;
    }
    public int GetProductID()
    {
        return productID;
    }
    // productName
    public void SetProductName(string value)
    {
        productName = value;
    }
    public string GetProductName()
    {
        return productName;
    }
    // cost
    public void SetCost(double value)
    {
        cost = value;
    }
    public double GetCost()
    {
        return cost;
    }
    // tax 
    public void SetTax(double value)
    {
        tax = value;
    }
    public double GetTax()
    {
        return tax;
    }
    // quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }
    // CategoryName
    public string GetCategoryName()
    {
        return CategoryName;
    }
    // dateOfPurchase    
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }
    /**     
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;
     */

    #endregion

    #region Constructor      
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
    #endregion

    #region Methods
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
