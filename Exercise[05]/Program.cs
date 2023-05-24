namespace Exercise_05_;

internal class Program
{
    static void Main(string[] args)
    {

        ManageStudents.students.AddLast(new Student()
        {
            TotalDegrees = 1,
        });
        ManageStudents.students.AddLast(new Student()
        {
            TotalDegrees = 5,
        });
        ManageStudents.students.AddLast(new Student()
        {
            TotalDegrees = 10,
        });
        ManageStudents.students.AddLast(new Student()
        {
            TotalDegrees = 7,
        });

        var result = ManageStudents.OrderByTotalDegrees(ManageStudents.students).GetEnumerator();
        while (result.MoveNext())
        {
            Console.WriteLine(result.Current.TotalDegrees);
        }
    }
}
