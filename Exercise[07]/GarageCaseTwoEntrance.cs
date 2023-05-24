namespace Exercise_07_;

public class GarageCaseTwoEntrance
{
    public static Queue<Car> cars = new();
    public static void Enqueue(Car car) =>
        cars.Enqueue(car);
    public static Car Dequeue()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("no cars in garage !");
            return null;
        }
        return cars.Dequeue();
    }
    public static Car Peek()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("no cars in garage !");
            return null;
        }
        return cars.Peek();
    }
    public static void Display()
    {
        var enumerator = cars.GetEnumerator();
        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Current);
    }
}