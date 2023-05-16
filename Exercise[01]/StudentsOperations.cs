namespace Exercise_01_;

public class StudentsOperations
{
    public static Student[] LoadStudents()
    {
        return new Student[]
        {
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 20},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 30},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 25},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 40},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 55},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 65},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 80},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 66},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 77},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 88},
        new () {Name = "Ahmed" , Age = 20 , TotalDegrees = 22},
        };
    }

    public static void OrderByTotalDegree(ref Student[] students)
    {
        for (int i = 0 ; i < students.Length ; i++)
            for (int j = 0 ; j < students.Length ; j++)
            {
                Student temp;
                if (students[i].TotalDegrees < students[j].TotalDegrees)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
    }
}



