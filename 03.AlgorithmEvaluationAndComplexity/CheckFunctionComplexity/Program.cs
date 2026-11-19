namespace CheckFunctionComplexity;
using System.Diagnostics;

class Program
{
    static void O2NPow2(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                
            }
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                
            }
        }
        
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedMs}ms to execute.");
    }

    static void O200N(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int end = 200 * n;

        for (int i = 1; i <= end; i++)
        {
            
        }
        
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedMs}ms to execute.");
    }

    static void ON(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedMs}ms to execute.");
    }
    
    static void ONPow2P1(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sum++;
            }
        }
        
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedMs}ms to execute.");
    }

    static void ONPow2P2(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int sum = 0;

        for (int i = 0; i < n * n; i++)
        {
            sum++;
        }
        
        watch.Stop();
        long elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedMs}ms to execute.");
    }
    
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 10, 100, 1000, 10000, 100000 };

        foreach(int num in nums)
        {
            // O2NPow2(num);
            // O200N(num);
            
            ON(num);
            ONPow2P1(num);
            ONPow2P2(num);
        }
    }
}