namespace Combinate_Letters;

class Program
{
    const int MAXN = 20;
    const int n = 5;
    const int k = 3;

    static char[] letters = { 'a', 'b', 'c', 'd', 'e' };
    static char[] mp = new char[MAXN];

    static void Print(int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{mp[i]} ");
        }

        Console.WriteLine();
    }

    static void CombineWithRepetition(int i, int after)
    {
        if (i > k)
        {
            return;
        }

        for (int j = after; j < n; j++)
        {
            mp[i - 1] = letters[j];

            if (i == k)
            {
                Print(i);
            }

            CombineWithRepetition(i + 1, j);
        }
    }

    static void CombineWithoutRepetition(int i, int after)
    {
        if (i > k)
        {
            return;
        }

        for (int j = after + 1; j < n; j++)
        {
            mp[i - 1] = letters[j];

            if (i == k)
            {
                Print(i);
            }

            CombineWithoutRepetition(i + 1, j);
        }
    }

    static void Main()
    {
        Console.WriteLine("Combinations without repetition:");
        CombineWithoutRepetition(1, -1);

        Console.WriteLine("\nCombinations with repetition:");
        CombineWithRepetition(1, 0);
    }
}