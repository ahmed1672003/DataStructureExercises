namespace Exercise_01_;

public struct Student
{
    public string Name { get; init; }
    public int Age { get; init; }
    public double TotalDegrees { get; init; }
    public Student() { }

    public override string? ToString() =>
         $"name:{Name} , age: {Age} , total degrees: {TotalDegrees}";
}



