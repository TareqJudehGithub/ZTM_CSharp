using ClassLibrary1;

namespace ClassSample
{
    public class Sample
    {
        Customer customer;
        static void Main(string[] args)
        {
            Console.WriteLine("Class sample!\n");

            // Reference variable
            Customer c1, c2;

            // Creating Objects
            c1 = new Customer();
            c2 = new Customer();

            int customer1ID = c1.customerID = 1;

            Console.WriteLine(customer1ID);

        }
    }
}

