using Exercise_06_.Repositories;

namespace Exercise_06_;

internal class Program
{
    static void Main(string[] args)
    {
        StudentRepository repository = new();
        repository.Add(new()
        {
            Number = 1,
            Name = "Ahmed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });
        repository.Add(new()
        {
            Number = 2,
            Name = "Ahmed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });
        repository.Add(new()
        {
            Number = 3,
            Name = "Ahmed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });
        repository.Add(new()
        {
            Number = 4,
            Name = "Ahmed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });


        repository.Delete(1);


        var result = repository.Display();
        result.PrintStudents();
    }
}

