namespace  Variate;

class Program
{
    const int MAXN = 100;
    const int n = 4;
    const int k = 2;

    static int[] taken = new int[MAXN];

    static void Print(int i)
    {
        Console.Write("( ");
        for (int l = 0; l <= i - 1; l++)
        {
            Console.Write($"{taken[l] + 1} ");
        }
        Console.WriteLine(")");
    }

    static void Variate(int i)
    {
        int j;

        if (i >= k)
        {
            Print(i);
            return;
        }

        for (j = 0; j < n; j++)
        {
            taken[i] = j;
            Variate(i + 1);
        }
    }

    static void Main()
    {
        Variate(0);
    }
}