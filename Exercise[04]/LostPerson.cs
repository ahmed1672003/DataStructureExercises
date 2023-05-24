namespace Exercise_04_;

public class LostPerson
{
    public static void HelpPerson()
    {
        Stack<int> steps = new();
        int counetr = 0;

        while (true)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1- Forward");
            Console.WriteLine("2- get last step");
            Console.WriteLine("3- Backward one step");
            Console.WriteLine("4- Back to start");
            Console.WriteLine("5- Display all steps");
            Console.WriteLine("6- stop");
            Console.WriteLine("==============================");
            Console.Write("enter option: ");
            var option = Console.ReadLine();
            var enumerator = steps.GetEnumerator();
            switch (option)
            {
                case "1":
                    steps.Push(++counetr);
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine($"step:[{steps.Peek()}]");
                    }
                    catch
                    {
                        Console.WriteLine("no steps founded !");
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine($"step:[{steps.Pop()}]");
                        counetr--;
                    }
                    catch
                    {
                        Console.WriteLine("no steps founded !");
                    }
                    break;
                case "4":
                    while (steps.Count > 0)
                        Console.WriteLine($"step:[{steps.Pop()}]");
                    counetr = 0;
                    break;
                case "5":
                    while (enumerator.MoveNext())
                        Console.WriteLine($"step:[{enumerator.Current}]");
                    break;
                case "6":
                    break;
            }
        }
    }

}
