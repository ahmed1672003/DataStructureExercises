namespace Exercise_06_.Models;

public class Student
{
    public int Number { get; set; }
    public string Name { get; set; }
    public double[] Degrees { get; set; }
    public string Grade
    {
        get
        {
            var percentages = Degrees.Sum() / Degrees.Length;
            if (percentages < 0)
                return "error !";
            else if (percentages > 0 && percentages < 60)
                return $"failed ! & percentages: {percentages}";
            else if (percentages >= 60 && percentages < 65)
                return $"Acceptable ! & percentages: {percentages}";
            else if (percentages >= 65 && percentages < 70)
                return $"Good ! & percentages: {percentages}";
            else if (percentages >= 70 && percentages < 85)
                return $"Very Good ! & percentages: {percentages}";
            else if (percentages >= 85 && percentages <= 100)
                return $"Excellent ! & percentages: {percentages}";
            else
                return $"error !";
        }
    }

    public override string ToString() =>
        $"number: {Number} , name: {Number} , Total: {Degrees.Sum()} , grade: {Grade}";

}

