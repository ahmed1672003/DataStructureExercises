using System.Diagnostics.CodeAnalysis;

public struct Term
{
    private Term(double exponent = 0, double coefficient = 0)
    {
        Exponent = exponent;
        Coefficient = coefficient;
    }
    public double Exponent { get; private set; }
    public double Coefficient { get; private set; }
    public static Term Create(double exponent = 0, double coefficient = 0) =>
        new(exponent, coefficient);

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (ReferenceEquals(null, obj))
            return false;

        return this.Exponent.Equals(((Term)obj).Exponent);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
