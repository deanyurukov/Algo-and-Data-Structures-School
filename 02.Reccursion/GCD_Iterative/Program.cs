namespace GCD_Iterative;

class Program
{
    static int GCD(int a, int b)
    {
        int swap;
        while (b > 0) {
            swap = b;
            b = a % b;
            a = swap;
        }
        return a;
    }
    
    static void Main(string[] args)
    {
        int gcdOf10And5 = GCD(10, 5);
        Console.WriteLine(gcdOf10And5);
    }
}