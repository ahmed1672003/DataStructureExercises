using System.Text;

public class Calculate
{
    public static Dictionary<List<Term>, StringBuilder> Sum(List<Term> firstEquation, List<Term> secondEquation)
    {
        StringBuilder resultString = new();
        List<Term> resultEquation = new();
        if (!firstEquation.Count.Equals(secondEquation.Count))
            return new() { { null!, resultString.Append("two equations not degree-two equations !") } };

        for (int i = 0 ; i < firstEquation.Count ; i++)
            for (int j = 0 ; j < secondEquation.Count ; j++)
            {
                if (firstEquation[i].Equals(secondEquation[j]))
                {
                    Term newTerm = Term.Create(
                        firstEquation[i].Exponent,
                        firstEquation[i].Coefficient + secondEquation[j].Coefficient);
                    resultEquation.Add(newTerm);

                    resultString.Append($"{newTerm.Coefficient}X^{newTerm.Exponent} ");
                }
            }
        return new() { { resultEquation, resultString } };
    }


    public static void GetRoot(List<Term> equation)
    {
        double a = 0, b = 0, c = 0;
        equation.ForEach(t =>
        {
            if (t.Exponent.Equals(2))
                a = t.Coefficient;
            if (t.Exponent.Equals(1))
                b = t.Coefficient;
            if (t.Exponent.Equals(0))
                c = t.Coefficient;
        });
        double discriminant = Math.Pow(b, 2) - (4 * (a * c));

        switch (discriminant)
        {
            case 0:
                Console.WriteLine($"one solution {-1 * b / (2 * a)}");
                break;
            case > 0:
                Console.WriteLine($"first solution: " +
                    $"{(-1 * b) + (Math.Sqrt(discriminant) / (2 * a))}");
                Console.WriteLine($"second solution: " +
                    $"{(-1 * b) - (Math.Sqrt(discriminant) / (2 * a))}");
                break;
            case < 0:
                Console.WriteLine("no solution !");
                break;
        }
    }
}
