namespace Exercise_07_;

public class GarageCaseOneEntrance
{
    public static Stack<Car> cars = new();
    public static void Push(Car car) =>
        cars.Push(car);
    public static Car Peek()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("no cars in garage !");
            return null!;
        }
        return cars.Peek();
    }
    public static Car Pop()
    {

        if (cars.Count == 0)
        {
            Console.WriteLine("no cars in garage !");
            return null;
        }
        return cars.Pop();
    }
    public static void Display()
    {
        var enumerator = cars.GetEnumerator();
        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Current);
    }
}
