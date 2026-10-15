namespace DecodeAndEncode;

class Program
{
    static int MAXN = 100;
    static int n = 6;
    static readonly int[] perm = { 5, 3, 6, 4, 2, 1 };
    // static int n = 4;
    // static readonly int[] perm = { 2, 3, 1, 4 };
    // static int n = 5;
    // static readonly int[] perm = { 5, 3, 2, 4, 1 };
    // static int n = 6;
    // static readonly int[] perm = { 3, 6, 4, 1, 5, 2 };
    
    static long code = 551;
    // static long code = 3;
    // static long code = 13;
    // static long code = 27;
    // static long code = 87;
    // static long code = 119;

    static int[] a = new int[MAXN];

    static long EncodePerm(int n, int[] perm)
    {
        int[] p = new int[MAXN];
        int i, pos;
        long r, result = 0;

        for (i = 0; i < n; i++)
        {
            p[i] = i + 1;
        }

        for (pos = 0; pos < n; pos++)
        {
            r = 0;

            while (perm[pos] != p[r])
            {
                r++;
            }

            result = result * (n - pos) + r;

            for (i = (int)r + 1; i < n; i++)
            {
                p[i - 1] = p[i];
            }
        }

        return result;
    }

    static void DecodePerm(long num, int n, int[] perm)
    {
        long[] m = new long[MAXN];
        int[] p = new int[MAXN];

        for (int i = 0; i < n; i++)
        {
            p[i] = i + 1;
        }

        for (int i = n - 1; i >= 0; i--)
        {
            m[i] = num % (n - i);
            num /= n - i;
        }

        for (int i = 0; i < n; i++)
        {
            long k = m[i];
            perm[i] = p[k];

            for (long j = k + 1; j < n - i; j++)
            {
                p[j - 1] = p[j];
            }
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