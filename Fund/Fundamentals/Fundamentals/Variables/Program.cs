namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables\n");

            // Declare a variable
            int a;
            a = 100;

            string name;
            name = "Scot";

            int age;
            age = 45;

            //Print a to Console
            Console.WriteLine(a);

            Console.WriteLine($"Hi {name}, your age is {age}");
        }
    }
}