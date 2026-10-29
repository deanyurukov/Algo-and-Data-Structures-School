namespace VariateLetters;

class Program
{
    const int MAXN = 100;
    const int n = 5;
    const int k = 3;

    static int[] taken = new int[MAXN];

    static char[] letters = { 'a', 'b', 'c', 'd', 'e' };

    static void PrintWithRepetition(int i)
    {
        Console.Write("( ");

        for (int l = 0; l < i; l++)
        {
            Console.Write($"{letters[taken[l]]} ");
        }

        Console.WriteLine(")");
    }

    static void PrintWithoutRepetition(int i)
    {
        HashSet<char> unique = new HashSet<char>();

        for (int l = 0; l < i; l++)
        {
            unique.Add(letters[taken[l]]);
        }

        if (unique.Count == i)
        {
            Console.Write("( ");

            for (int l = 0; l < i; l++)
            {
                Console.Write($"{letters[taken[l]]} ");
            }

            Console.WriteLine(")");
        }
    }

    static void VariateWithRepetition(int i)
    {
        int j;
        
        if (i >= k)
        {
            PrintWithRepetition(i);
            return;
        }

        for (j = 0; j < n; j++)
        {
            taken[i] = j;
            VariateWithRepetition(i + 1);
        }
    }

    static void VariateWithoutRepetition(int i)
    {
        int j;

        if (i >= k)
        {
            PrintWithoutRepetition(i);
            return;
        }

        for (j = 0; j < n; j++)
        {
            taken[i] = j;
            VariateWithoutRepetition(i + 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Variate with repetition:");
        VariateWithRepetition(0);
        Console.WriteLine("Variate without repetition:");
        VariateWithoutRepetition(0);
    }
}