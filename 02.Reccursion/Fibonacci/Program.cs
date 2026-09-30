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
        int tenthNumberOfFibonacci = Fibonacci(10);
        int eleventhNumberOfFibonacci = Fibonacci(11);

        Console.WriteLine((double) eleventhNumberOfFibonacci / tenthNumberOfFibonacci);
    }
}