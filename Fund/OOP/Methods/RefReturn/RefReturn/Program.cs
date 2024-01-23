internal class Student
{
    #region fields
    public int grade = 2;
    #endregion

    #region methods
    public void PrintGrade()
    {
        Console.WriteLine($"Grade: {grade}");
    }

    // Method with ref return
    public ref int DoWork()
    {
        // return ref of "grade" field
        return ref grade;

    }
    #endregion
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ref returns\n");

        // Objects
        Student student = new Student();
        student.PrintGrade();

        ref int gradeRef = ref student.DoWork();
        Console.WriteLine(gradeRef);

        gradeRef = 5;
        student.PrintGrade();

    }
}