using Exercise_06_.Models;

namespace Exercise_06_;
public static class Helper
{
    public static void PrintStudents(this Student[] students)
    {
        for (int i = 0 ; i < students.Length ; i++)
            Console.WriteLine(students[i]);
    }
}
