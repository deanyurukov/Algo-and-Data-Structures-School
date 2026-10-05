namespace GCD_Recursive;

class Program
{
    static int GCD(int a, int b)
    {
        return (0 == b) ? a : GCD(b, a % b);
    }
    
    static void Main(string[] args)
    {
        int gcdOf10And5 = GCD(10, 5);
        Console.WriteLine(gcdOf10And5);
    }
}