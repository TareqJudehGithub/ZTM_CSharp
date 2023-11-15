namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nest Loops\n");

            for (int i = 1; i <= 5; i++)
            {
                //  if (i > 1 && i < 5) Console.Write(i);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}