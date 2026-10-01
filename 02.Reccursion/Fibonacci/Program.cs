namespace Fibonacci;

class Program
{
    static public int Fibonacci(int n)
    {
        if (n == 0 || n == 1) 
        {
            return 1;
        }
        
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    
    static void Main()
    {
        int numberToCalc = 10;

        Console.WriteLine((double) Fibonacci(numberToCalc + 1) / Fibonacci(numberToCalc));
    }
}