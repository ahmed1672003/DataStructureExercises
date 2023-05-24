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
            Name = "Amr",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });
        repository.Add(new()
        {
            Number = 3,
            Name = "Mohamed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });
        repository.Add(new()
        {
            Number = 4,
            Name = "Ahmed",
            Degrees = new double[5] { 60, 70, 80, 90, 100 }
        });

        repository.Edit(new()
        {
            Number = 1,
            Name = "Ahmed",
            Degrees = new double[5] { 50, 50, 50, 50, 50 }
        }, 1);
        //repository.Delete(1);

        // filter to search by name if contains or not
        var result = repository.Display(e => e.Name.Contains("Ahm"));
        result.PrintStudents();
    }
}

