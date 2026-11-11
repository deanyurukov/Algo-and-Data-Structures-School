namespace NumberPartitionReverse_Recursive;

class Program
{
    const int MAXN = 100;
    
    static int[] mp = new int[MAXN + 1];
    static List<string> results = new List<string>();

    static void Print(int length)
    {
        for (int i = 1; i < length; i++)
        {
            results.Add($"{mp[i]}+");
        }

        results.Add((mp[length]).ToString());
    }

    static void NumberPartitionReverse(int n, int pos)
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
                    NumberPartitionReverse(n - k, pos + 1);
                }
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        mp[0] = n + 1;
        NumberPartitionReverse(n, 1);
        Console.WriteLine(String.Join("\n", results));
    }
}