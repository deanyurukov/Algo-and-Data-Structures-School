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
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(O2NPow2)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void O200N(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int end = 200 * n;

        for (int i = 1; i <= end; i++)
        {

        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(O200N)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void ONP1(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONP1)}: With n = {n}, code took {elapsedNs}ns to execute.");
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
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow2P1)}: With n = {n}, code took {elapsedNs}ns to execute.");
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
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow2P2)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void ONPow2P3(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    for (int k = 0; k < n; k++)
                    {
                        sum++;
                    }
                }
            }
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow2P3)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void ONPow2P4(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    break;
                }
            }
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow2P4)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void ONPow3(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i * i; j++)
            {
                sum++;
            }
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow3)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void ONPow4(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i * i; j++)
            {
                for (int k = 1; k <= j * j; k++)
                {
                    sum++;
                }
            }
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(ONPow4)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static void OLogN(int n)
    {
        Stopwatch watch = Stopwatch.StartNew();

        for (int sum = 0, h = 1; h < n; h *= 2)
        {
            sum++;
        }

        watch.Stop();
        double elapsedNs = watch.Elapsed.TotalNanoseconds;
        Console.WriteLine($"{nameof(OLogN)}: With n = {n}, code took {elapsedNs}ns to execute.");
    }

    static int ONP2(int n)
    {
        if (n < 2)
        {
            return 1;
        }

        return n * ONP2(n - 1);
    }

    static int ONP3(int n)
    {
        if (n < 2)
        {
            return 1;
        }

        return ONP3(n - 1) + ONP3(n - 2);
    }

    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 10, 100, 1000, 10000 };

        foreach (int num in nums)
        {
            // O2NPow2(num);
            // O200N(num);

            ONP1(num);
            ONPow2P1(num);
            ONPow2P2(num);
            ONPow2P3(num);
            ONPow2P4(num);
            ONPow3(num);
            ONPow4(num);
            OLogN(num);

            Stopwatch watch1 = Stopwatch.StartNew();

            ONP2(num);

            watch1.Stop();
            double elapsedNs1 = watch1.Elapsed.TotalNanoseconds;
            Console.WriteLine($"{nameof(ONP2)}: With n = {num}, code took {elapsedNs1}ns to execute.");

            Stopwatch watch2 = Stopwatch.StartNew();

            ONP3(num);

            watch2.Stop();
            double elapsedNs2 = watch2.Elapsed.TotalNanoseconds;
            Console.WriteLine($"{nameof(ONP3)}: With n = {num}, code took {elapsedNs2}ns to execute.");

            Console.WriteLine();
        }
    }
}