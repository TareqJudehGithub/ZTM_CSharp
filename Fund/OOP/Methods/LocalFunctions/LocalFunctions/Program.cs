namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Local functions\n");

            Student student = new Student();
            student.DisplayMarks(80, 45, 71);

        }
    }

    class Student
    {
        internal void DisplayMarks(params int[] marks)
        {
            int sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
                sum += marks[i];
            }


            // Marks average
            double avg = sum / marks.Length;

            Console.WriteLine($"\nThe student average = {avg}");
        }
    }
}
