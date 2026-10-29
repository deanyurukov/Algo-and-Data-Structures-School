namespace Variation_DecodeAndEncode;

class Program
{
    const int n = 4;
    const int k = 2;

    static long EncodeWithRepetition(int[] variation)
    {
        long result = 0;

        for (int i = 0; i < k; i++)
        {
            result = result * n + variation[i] - 1;
        }

        return result;
    }

    static int[] DecodeWithRepetition(long code)
    {
        long total = 1;

        for (int i = 0; i < k; i++)
        {
            total *= n;
        }

        int[] variation = new int[k];

        for (int i = k - 1; i >= 0; i--)
        {
            variation[i] = (int)(code % n) + 1;
            code /= n;
        }

        return variation;
    }

    static long EncodeWithoutRepetition(int[] variation)
    {
        int[] available = new int[n];

        for (int i = 0; i < n; i++)
        {
            available[i] = i + 1;
        }

        long result = 0;
        int remaining = n;

        for (int i = 0; i < k; i++)
        {
            int position = 0;

            while (position < remaining && available[position] != variation[i])
            {
                position++;
            }

            result = result * remaining + position;

            for (int j = position; j < remaining - 1; j++)
            {
                available[j] = available[j + 1];
            }

            remaining--;
        }

        return result;
    }
    
    static int[] DecodeWithoutRepetition(long code)
    {
        long total = 1;

        for (int i = 0; i < k; i++)
        {
            total *= n - i;
        }

        long[] digits = new long[k];

        for (int i = k - 1; i >= 0; i--)
        {
            digits[i] = code % (n - i);
            code /= n - i;
        }

        int[] available = new int[n];

        for (int i = 0; i < n; i++)
        {
            available[i] = i + 1;
        }

        int[] variation = new int[k];
        int remaining = n;

        for (int i = 0; i < k; i++)
        {
            int position = (int)digits[i];

            variation[i] = available[position];

            for (int j = position; j < remaining - 1; j++)
            {
                available[j] = available[j + 1];
            }

            remaining--;
        }

        return variation;
    }

    static void Main()
    {
        int[] withRepetition = { 3, 3 };
        long code1 = EncodeWithRepetition(withRepetition);
        int[] decoded1 = DecodeWithRepetition(code1);

        Console.WriteLine("With repetition:");
        Console.WriteLine("Original: " + string.Join(" ", withRepetition));
        Console.WriteLine("Encoded: " + code1);
        Console.WriteLine("Decoded: " + string.Join(" ", decoded1));

        int[] withoutRepetition = { 2, 4 };
        long code2 = EncodeWithoutRepetition(withoutRepetition);
        int[] decoded2 = DecodeWithoutRepetition(code2);

        Console.WriteLine("\nWithout repetition:");
        Console.WriteLine("Original: " + string.Join(" ", withoutRepetition));
        Console.WriteLine("Encoded: " + code2);
        Console.WriteLine("Decoded: " + string.Join(" ", decoded2));
    }
}