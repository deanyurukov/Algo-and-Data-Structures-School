namespace NumberMultiplicateReverse_Recursive;

class Program
{
    const int MAXLN = 20;
    const int n = 50;

    static int[] mp = new int[MAXLN];

    static void Print(int length)
    {
        for (int i = 1; i < length; i++)
        {
            Console.Write($"{mp[i]} * ");
        }

        Console.WriteLine(mp[length]);
    }

    static void DevNum(int n, int pos)
    {
        if (n == 1)
        {
            Print(pos - 1);
        }
        else
        {
            for (int k = 2; k <= n; k++)
            {
                mp[pos] = k;

                if (mp[pos] <= mp[pos - 1] && n % k == 0)
                {
                    DevNum(n / k, pos + 1);
                }
            }
        }
    }

    static void Main()
    {
        mp[0] = n + 1;
        DevNum(n, 1);
    }
}