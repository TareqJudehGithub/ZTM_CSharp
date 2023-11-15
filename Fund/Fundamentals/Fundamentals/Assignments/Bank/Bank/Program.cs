namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Project - Presentation\n");

            // Display Title
            Console.WriteLine("********Local Bank********");

            // Declare variables storing username/password variables
            string username = null, password = null;

            // Read user
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.WriteLine($"This is the username: {username}");


        }
    }
}