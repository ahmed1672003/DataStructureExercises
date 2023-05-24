namespace Exercise_01_;

public struct Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double TotalDegrees { get; set; }
    public Student() { }

    public override string? ToString() =>
         $"name:{Name} , age: {Age} , total degrees: {TotalDegrees}";
}



