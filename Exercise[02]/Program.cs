namespace Exercise_02_;

internal class Program
{
    static void Main(string[] args)
    {
        var resultPairs = Calculate.Sum(
            new()
            {
                Term.Create(2 ,2),
                Term.Create(1 ,3),
                Term.Create(0 ,1),
            },
        new()
            {
                Term.Create(2 ,3),
                Term.Create(1 ,3),
                Term.Create(0 ,0),
            }
        ).FirstOrDefault();

        var result = resultPairs.Value.ToString().Trim().Replace(" ", " + ");
        Console.WriteLine(result);
        Calculate.GetRoot(resultPairs.Key);
    }
}
