using Exercise_06_.IRepositories;
using Exercise_06_.Models;

namespace Exercise_06_.Repositories;
public class StudentRepository : IStudentRepository
{
    static Student[] students = new Student[0];
    public void Add(Student student)
    {
        Resize(students.Length + 1);
        students[students.Length - 1] = student;
    }
    public void Delete(int number)
    {
        for (int i = 0 ; i < students.Length ; i++)
        {
            if (students[i].Number == number)
                students[i] = null;
        }

        Resize(students.Length - 1);
    }
    public Student[] Display(Func<Student, bool> filter = null) =>
         filter == null ? students : students.Where(filter).ToArray();
    public void Edit(Student student, int number)
    {
        for (int i = 0 ; i < students.Length ; i++)
            if (students[i].Number == number)
                students[i] = student;
    }
    public void Resize(int newSize)
    {
        Student[] newStudents;
        if (newSize > students.Length)
        {
            newStudents = new Student[newSize];
            for (int i = 0 ; i < students.Length ; i++)
                newStudents[i] = students[i];
            students = newStudents;
        }
        else
        {
            newStudents = new Student[newSize];
            for (int i = 0, j = 0 ; i < students.Length ; i++)
            {
                if (students[i] != null)
                {
                    newStudents[j] = students[i];
                    j++;
                }
            }
            students = newStudents;
        }
    }
}
