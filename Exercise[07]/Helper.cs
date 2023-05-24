namespace Exercise_07_;
public static class Helper
{
    public static void RunGarageCaseOneEntrance(this Stack<Car> cars)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1- Add car");
            Console.WriteLine("2- Remove last car");
            Console.WriteLine("3- Retrieve last car");
            Console.WriteLine("4- Show All Cars");
            Console.WriteLine("5- Remove All Cars");
            Console.WriteLine("6- Exit");
            Console.WriteLine("===========================");
            Console.Write("enter option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    GarageCaseOneEntrance.Push(new() { Letters = "abc", Number = 123 });
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(GarageCaseOneEntrance.Pop());
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(GarageCaseOneEntrance.Peek());
                    Console.ReadKey();
                    break;
                case "4":
                    GarageCaseOneEntrance.Display();
                    Console.ReadKey();
                    break;
                case "5":
                    while (GarageCaseOneEntrance.cars.Count > 0)
                        Console.WriteLine(GarageCaseOneEntrance.Pop());
                    Console.ReadKey();
                    break;
                case "6":
                    break;
            }
        }
    }
    public static void RunGarageCaseTwoEntrance(this Queue<Car> cars)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1- Add car");
            Console.WriteLine("2- Remove last car");
            Console.WriteLine("3- Retrieve last car");
            Console.WriteLine("4- Show All Cars");
            Console.WriteLine("5- Remove All Cars");
            Console.WriteLine("6- Exit");
            Console.WriteLine("===========================");
            Console.Write("enter option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    GarageCaseTwoEntrance.Enqueue(new() { Letters = "abd", Number = 123 });
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(GarageCaseTwoEntrance.Dequeue());
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(GarageCaseTwoEntrance.Peek());
                    Console.ReadKey();
                    break;
                case "4":
                    GarageCaseTwoEntrance.Display();
                    Console.ReadKey();
                    break;
                case "5":
                    while (GarageCaseTwoEntrance.cars.Count > 0)
                        Console.WriteLine(GarageCaseTwoEntrance.Dequeue());
                    Console.ReadKey();
                    break;
                case "6":
                    break;
            }
        }
    }
}
