namespace Param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("params keyword\n");

            // Obj
            Student student = new Student();


            student.DisplaySubjects("Math", "Religion", "Science", "Physics", "Art", "English");
        }
    }
    internal class Student
    {
        public void DisplaySubjects(params string[] subjects)
        {
            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }

        }
    }
}
