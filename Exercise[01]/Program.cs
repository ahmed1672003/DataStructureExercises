namespace Exercise_01_;

internal class Program
{
    static void Main(string[] args)
    {
        var students = StudentsOperations.LoadStudents();
        StudentsOperations.OrderByTotalDegree(ref students);

        foreach (var student in students)
            Console.WriteLine(student);
    }
}



