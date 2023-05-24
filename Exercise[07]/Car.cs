namespace Exercise_07_;

public class Car
{
    public int Number { get; set; }
    public string Letters { get; set; }
    public string Plate
    {
        get { return $"[{Number}] , [{Letters}]"; }
    }
    public override string ToString() =>
        $"plate: {Plate}";
}
