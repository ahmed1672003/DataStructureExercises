using Exercise_06_.Models;

namespace Exercise_06_.IRepositories;
public interface IStudentRepository
{
    void Add(Student student);
    void Edit(Student student, int number);
    void Delete(int number);
    Student[] Display(Func<Student, bool> filter = null);
    void Resize(int newSize);
}
