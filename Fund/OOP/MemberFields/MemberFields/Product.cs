namespace MemberFields
{
    internal class Product
    {
        #region Fields

        // Static fields
        public static int totalNoProducts;

        // Constant fields
        public const string CatergoryName = "Electronics";

        // Local constant
        const string developerName = "Tareq";
        // readonly fields;
        public readonly string dateOfPurchase;
        public readonly int expDate = 2028;
        // Instance fields
        public int productID;
        public string productName;
        public double cost;
        public int quantityInStock;
        #endregion

        #region Constructors

        public Product()
        {
            // Today's date
            dateOfPurchase = DateTime.Now.ToShortDateString();
        }
        #endregion
    }
}
