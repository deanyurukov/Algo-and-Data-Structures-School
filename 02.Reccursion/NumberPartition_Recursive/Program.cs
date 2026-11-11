namespace NumberPartition_Recursive;

class Program
{
    const int MAXN = 100;
    static int[] mp = new int[MAXN + 1];

    static void Print(int length)
    {
        for (int i = 1; i < length; i++)
        {
            Console.Write($"{mp[i]}+");
        }

        Console.WriteLine(mp[length]);
    }

    static void NumberPartition(int n, int pos)
    {
        if (n == 0)
        {
            Print(pos - 1);
        }
        else
        {
            for (int k = n; k >= 1; k--)
            {
                mp[pos] = k;

                if (mp[pos] <= mp[pos - 1])
                {
                    NumberPartition(n - k, pos + 1);
                }
            }
        }
    }

    static void Main()
    {
        int n =  int.Parse(Console.ReadLine());
        mp[0] = n + 1;
        NumberPartition(n, 1);
    }
}