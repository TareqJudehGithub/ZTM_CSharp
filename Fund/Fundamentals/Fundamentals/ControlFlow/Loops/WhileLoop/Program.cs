namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop\n");

            //Initialization

            int i = 1;

            while (i < 10)
            {
                Console.WriteLine($"i = {i}");
                i++;
            }
        }
    }
}