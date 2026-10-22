namespace DecodeAndEncodeWithRepetitions;

class Program
{
    static int MAXN = 100;
    static int n = 4;
    private static readonly int[] perm = { 1, 1, 2, 3 };
    
    static long code = 6;

    static int[] a = new int[MAXN];

    static long EncodePerm(int n, int[] perm)
    {
        int[] p = new int[n];
        long result = 0;

        for (int i = 0; i < n; i++)
            p[i] = i + 1;

        for (int pos = 0; pos < n; pos++)
        {
            int r = 0;

            while (perm[pos] != p[r])
                r++;

            result = result * n + r;
        }

        return result;
    }

    static void DecodePerm(long num, int n, int[] perm)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            perm[i] = (int)(num % n) + 1;
            num /= n;
        }
    }

    static void Main()
    {
        for (int i = 0; i < n; i++)
        {
            a[i] = i;
        }

        Console.WriteLine("Permutation gets encoded to: " + EncodePerm(n, perm));

        int[] decoded = new int[n];
        DecodePerm(code, n, decoded);

        Console.WriteLine("Permutation gets decoded to: " + string.Join(" ", decoded));
    }
}