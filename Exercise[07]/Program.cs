namespace Exercise_07_;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1- Garage Case One Entrance");
            Console.WriteLine("1- Garage Case Two Entrance");
            Console.WriteLine("3- Exit");
            Console.WriteLine("============================");
            Console.Write("enter option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    GarageCaseOneEntrance.cars.RunGarageCaseOneEntrance();
                    Console.ReadKey();
                    break;
                case "2":
                    GarageCaseTwoEntrance.cars.RunGarageCaseTwoEntrance();
                    Console.ReadKey();
                    break;
                case "3":
                    break;
            }

        }
    }
}
