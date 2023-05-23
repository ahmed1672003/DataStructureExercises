namespace Exercise_03_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter text: ");
        Console.WriteLine((Console.ReadLine()!).IsBalanced());
    }
}
