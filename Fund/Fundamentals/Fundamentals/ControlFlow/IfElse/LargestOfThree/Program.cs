namespace LargestOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest of Three\n");

            int a = 150, b = -2500, c = 2270;
            int largestNumber;

            if (a > b && a > c) largestNumber = a;
            else if (b > a && b > c) largestNumber = b;
            else largestNumber = c;

            Console.WriteLine($"The largest number uquals {largestNumber}");


        }
    }
}