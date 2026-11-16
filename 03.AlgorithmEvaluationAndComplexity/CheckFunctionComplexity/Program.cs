using System.Diagnostics;

namespace CheckFunctionComplexity;

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
        long elapsedNanoseconds = watch.Elapsed.Nanoseconds;

        Console.WriteLine($"With n = {n}, code took {elapsedNanoseconds} nanoseconds to execute.");
    }

    static void O200N(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int end = 200 * n;

        for (int i = 1; i <= end; i++)
        {
            
        }
        
        watch.Stop();
        long elapsedNanoseconds = watch.Elapsed.Nanoseconds;
        Console.WriteLine($"With n = {n}, code took {elapsedNanoseconds} nanoseconds to execute.");
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("O(2 * n * n)");
        O2NPow2(10);
        O2NPow2(100);
        O2NPow2(1000);
        O2NPow2(10000);
        O2NPow2(100000);
        // O2NPow2(1000000);

        Console.WriteLine("\nO(200 * n)");
        O200N(10);
        O200N(100);
        O200N(1000);
        O200N(10000);
        O200N(100000);
        // O200N(1000000);
    }
}