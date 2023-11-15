namespace SecsToMins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seconds to Minutes\n");

            Console.Write("Enter time in seconds: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int minutes = input / 60;
            int hour = minutes / 60;

            Console.WriteLine($"{input} seconds equal {minutes} minute(s)");
            Console.WriteLine($"{minutes} minutes equal {hour} hour(s)");

        }
    }
}