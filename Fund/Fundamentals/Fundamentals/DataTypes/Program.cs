namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types\n");

            sbyte a = sbyte.MinValue;

            Console.WriteLine(default(sbyte));
            Console.WriteLine(default(char));
            Console.WriteLine(default(string));
        }
    }
}