namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If statements\n");

            int mark = 45;

            if (mark >= 35)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Hard luck!\n\n");
            }

            // student grades
            Console.Write("Enter a student mark: ");
            int studentMark = Convert.ToInt32(Console.ReadLine());

            // Using if-else
            if (studentMark >= 85)
            {
                Console.WriteLine("A+");
            }
            else if (studentMark >= 60 && studentMark < 85)
            {
                Console.WriteLine("A");
            }
            else if (studentMark >= 50 && studentMark < 60)
            {
                Console.WriteLine("B");
            }
            else if (studentMark >= 35 && studentMark < 50)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }



        }
    }
}