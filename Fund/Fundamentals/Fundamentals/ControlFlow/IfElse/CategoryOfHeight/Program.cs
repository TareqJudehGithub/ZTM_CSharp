namespace CategoryOfHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height Category\n");

            //Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            if (height >= 180)
            {
                Console.WriteLine("Tall.");
            }
            else if (height >= 160 && height < 180)
            {
                Console.WriteLine("Average height.");
            }
            else
            {
                Console.WriteLine("Short.");
            }


        }
    }
}