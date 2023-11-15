namespace FeetToCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 3\n");
            //Write a C# program convert a person's height (in feet and inches) to centimeters.

            decimal feet = 3.2m;
            decimal feetToInches = feet * 12;
            Console.WriteLine($"a {feet} feet is equal to {feetToInches} in inches.");
        }
    }
}