namespace DecodeAndEncode;

class Program
{
    static int MAXN = 100;
    static int n = 6;
    static readonly int[] perm = { 5, 3, 6, 4, 2, 1 };
    static long code = 551;

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

    static void Print()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    static void Permut(int k)
    {
        int swap;

        if (k == 0)
        {
            Print();
        }
        else
        {
            Permut(k - 1);

            for (int i = 0; i < k - 1; i++)
            {
                swap = a[i];
                a[i] = a[k - 1];
                a[k - 1] = swap;

                Permut(k - 1);

                swap = a[i];
                a[i] = a[k - 1];
                a[k - 1] = swap;
            }
        }
    }

    static void Main()
    {
        for (int i = 0; i < n; i++)
        {
            a[i] = i;
        }

        Permut(n);

        Console.WriteLine("\nPermutation gets encoded to: " + EncodePerm(n, perm));

        int[] decoded = new int[n];
        DecodePerm(code, n, decoded);

        Console.WriteLine("Permutation gets decoded to: " + string.Join(" ", decoded));
    }
}