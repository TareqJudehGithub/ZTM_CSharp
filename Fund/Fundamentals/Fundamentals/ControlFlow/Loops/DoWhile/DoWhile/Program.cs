namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do - While loop\n");

            // The do-while loop first checks the condition in the do block of code, then executes that code.
            // The do-while loop first checks the condition in the do block of code, then executes that code.
            int i = 1;
            do
            {
                Console.WriteLine($"i = {i}");
                i++;
            }
            while (i <= 10);

        }
    }
}