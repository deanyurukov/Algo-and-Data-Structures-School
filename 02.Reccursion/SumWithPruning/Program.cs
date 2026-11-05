namespace SumWithPruning;

class Program
{
    const int n = 8;
    static int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
    static int[] signs = new int[n];

    static void CheckSol(int sum)
    {
        if (sum == 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{(signs[i] > 0 ? "+" : "-")}{a[i]} ");
            }

            Console.WriteLine("= 0");
        }
    }

    static void Variate(int i, int currentSum, int remainingSum)
    {
        if (i >= n)
        {
            CheckSol(currentSum);
            return;
        }

        remainingSum -= a[i];

        signs[i] = 1;
        int newSum = currentSum + a[i];

        if (Math.Abs(newSum) <= remainingSum)
        {
            Variate(i + 1, newSum, remainingSum);
        }
        else if (i == n - 1)
        {
            CheckSol(newSum);
        }

        signs[i] = -1;
        newSum = currentSum - a[i];

        if (Math.Abs(newSum) <= remainingSum)
        {
            Variate(i + 1, newSum, remainingSum);
        }
        else if (i == n - 1)
        {
            CheckSol(newSum);
        }
    }

    static void Main()
    {
        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += a[i];
        }

        Variate(0, 0, totalSum);
    }
}