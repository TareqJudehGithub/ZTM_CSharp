namespace BankPresentation
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

            // Display password, but only if the user has a username
            if (username != "")
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            if (username == "system" && password == "manager")
            {

                // Variable for user's choice - defaul -1, assuming the user has not made any choice yet
                int mainMenuChoice = -1;
                do
                {
                    Console.Clear();

                    Console.WriteLine("::: Main Menu :::");
                    Console.WriteLine("1. Customer");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");
                    // Prompt user for menu choice selection
                    Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    // switch statement to chk user's input
                    switch (mainMenuChoice)
                    {
                        case 1:
                            // ToDo: Customers menu
                            Console.Clear();
                            CustomersMenu();
                            break;
                        case 2:
                            // ToDo: Accounts  menu
                            Console.Clear();
                            AccountsMenu();
                            break;
                        case 3:
                            // ToDo: Funds Transfer menu
                            Console.WriteLine("Fund Transfer menu");
                            break;
                        case 4:
                            // ToDo: Funds Transfer Statement  menu
                            Console.WriteLine("Fund Transfer Statemen menu");
                            break;
                        case 5:
                            // ToDo: Account Statement  menu
                            Console.WriteLine("Account Statement menu");
                            break;
                        case 0:
                            // ToDo:
                            break;
                        default:
                            Console.WriteLine("Invalid user input!");
                            break;
                    }
                }
                while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

            // Exit program
            Console.WriteLine("Thank you! Visit again!");
            Console.ReadKey();
        }
        static void CustomersMenu()
        {

            int customerMenuChoice = -1;

            do
            {
                Console.WriteLine(":::Customers Menu:::");
                Console.WriteLine("1. Add a new customer");
                Console.WriteLine("2. Delete a customer");
                Console.WriteLine("3. Update a customer");
                Console.WriteLine("4. View  a customer");
                Console.WriteLine("0. Back to Main Menu");

                // User input
                Console.Write("Enter a choice: ");
                customerMenuChoice = Convert.ToInt32(Console.ReadLine());

                switch (customerMenuChoice)
                {
                    case 1:
                        Console.WriteLine("Add New Customer form");
                        break;
                    case 2:
                        Console.WriteLine("Delete Customer form");
                        break;
                    case 3:
                        Console.WriteLine("Update Customer form");
                        break;
                    case 4:
                        Console.WriteLine("View Customers form");
                        break;
                    case 5:
                        Console.WriteLine("Main menu method and break out of this loop");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

            }
            while (customerMenuChoice != 0);
        }
        static void AccountsMenu()
        {

            int accountMenuChoice = -1;

            do
            {
                Console.WriteLine(":::Accounts Menu:::");
                Console.WriteLine("1. Add a new account");
                Console.WriteLine("2. Delete a account");
                Console.WriteLine("3. Update a account");
                Console.WriteLine("4. View  a account");
                Console.WriteLine("0. Back to Main Menu");

                // User input
                Console.Write("Enter a choice: ");
                accountMenuChoice = Convert.ToInt32(Console.ReadLine());

                switch (accountMenuChoice)
                {
                    case 1:
                        Console.WriteLine("Add New Customer form");
                        break;
                    case 2:
                        Console.WriteLine("Delete Customer form");
                        break;
                    case 3:
                        Console.WriteLine("Update Customer form");
                        break;
                    case 4:
                        Console.WriteLine("View Customers form");
                        break;
                    case 5:
                        Console.WriteLine("Main menu method and break out of this loop");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

            }
            while (accountMenuChoice != 0);
        }

    }

}