namespace FractionSimpler;

class Fraction
{
    private int nominator, denominator;

    public Fraction(int nominator, int denominator)
    {
        this.nominator = nominator;
        this.denominator = denominator;
    }

    public override string ToString()
    {
        int gcd = GCD(nominator, denominator);
        return $"{nominator / gcd} / {denominator / gcd}";
    }

    private static int GCD(int a, int b)
    {
        return (0 == b) ? a : GCD(b, a % b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter nominator:");
        int nominator = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter denominator:");
        int denominator = int.Parse(Console.ReadLine());
        
        Fraction fraction = new Fraction(nominator, denominator);
        Console.WriteLine(fraction);
    }
}