namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of a circle\n");
            // Write a C# program to calculate "area of circle" based on the given "radius" value.

            double radius = 4D;
            double diameter = 10D;
            double PI = 3.14D;

            double area = PI * (radius * radius);
            Console.WriteLine(area);


        }
    }
}