namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ForLoop\n");

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                    Console.WriteLine("Don't show me!");
                }
                if (i == 5)
                {
                    Console.WriteLine("Breaking out of the look");
                    break;
                }
                Console.WriteLine($"i = {i}");
            }
        }
    }
}