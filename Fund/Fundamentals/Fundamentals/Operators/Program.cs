namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators\n");

            //Arithmetical Operators
            decimal a = 10.5M;
            float b = 45.25F;
            long c = 25;
            int d = 15;

            Console.WriteLine(a + 5);
            Console.WriteLine(b - 20);
            Console.WriteLine(c + d);

            a += 15M;
            Console.WriteLine($"This is the value of {nameof(a)} ={a}");

            // modulo %
            Console.WriteLine($"This is the remainder of {d} % 2 ={d % 2}");
        }
    }
}