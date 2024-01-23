namespace MethodsModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Modifiers\n");

            double taxPercent = 0.10;
            Console.WriteLine($"Tax amount = {CalculateTax(1000, taxPercent: ref taxPercent)}");

            ConvertStrToInt();

            //string fullName = ;
            Console.WriteLine(DisplayName());

            Console.WriteLine(DisplayInteger(14));
        }

        // default

        // ref
        /*
         * ref keyword overrides the variable original value used in the method argument when called.
         */
        static double CalculateTax(double cost, ref double taxPercent)
        {
            double taxAmount;
            taxPercent = 0.15;
            taxAmount = cost * taxPercent;
            return taxAmount;
        }
        // out
        /*
         * This is the oppesite of 'default arguments'. The latest value of the parameter will be
         * assigned into the argument.
         */
        static void ConvertStrToInt()
        {
            string userChoice = string.Empty;

            Console.Write("Enter a number: ");
            userChoice = Console.ReadLine();

            bool isNumber = int.TryParse(userChoice, out int strToInt);

            if (isNumber)
            {
                Console.WriteLine($"{strToInt} is an interger");
            }
            else
            {
                Console.WriteLine($"{strToInt} could no be converted to an integer.");
            }

        }


        // in
        /*
         The parameter becomes read only, and cannot be modified from inside the method.
         */

        static string DisplayName(in string name = "John Smith")
        {
            // name = "Sarah Adams";
            return name;

        }

        static int DisplayInteger(in int num = 15)
        {
            return num;
        }


    }
}
