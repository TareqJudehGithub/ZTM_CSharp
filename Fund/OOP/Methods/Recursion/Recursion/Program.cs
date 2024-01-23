namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion\n");

            // Recursion is when a method calls it self.

            // Find out the factorial of a number provided by the user.

            //Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            bool isInt = Int32.TryParse(number, out int intNum);

            if (isInt)
            {
                double factorial = FindFactorial(intNum);
                Console.WriteLine(factorial);
            }
            else
            {
                Console.WriteLine("Input is not an integer.");
            }

            double FindFactorial(int intNum)
            {


                if (intNum == 0) return 1;
                else
                {
                    return intNum * (FindFactorial(intNum - 1));
                }
            }
        }
    }
}
