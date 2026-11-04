namespace SumZero;

class Program
{
    const int n = 8;
    static int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
    static int sum = 0;

    static void CheckSol()
    {
        int tempSum = 0;

        for (int i = 0; i < n; i++)
        {
            tempSum += a[i];
        }

        if (tempSum == sum)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    Console.Write($"+{a[i]} ");
                }
                else
                {
                    Console.Write($"{a[i]} ");
                }
            }

            Console.WriteLine($"= {tempSum}");
        }
    }

    static void Variate(int i)
    {
        if (i >= n)
        {
            CheckSol();
            return;
        }

        a[i] = Math.Abs(a[i]);
        Variate(i + 1);

        a[i] = -Math.Abs(a[i]);
        Variate(i + 1);
    }

    static void Main()
    {
        Variate(0);
    }
}