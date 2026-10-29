namespace Variate_Recursive;

class Program
{
    const int MAXN = 100;
    const int n = 4;
    const int k = 2;

    static int[] taken = new int[MAXN];

    static void PrintWithRepetition(int i)
    {
        Console.Write("( ");
        
        for (int l = 0; l <= i - 1; l++)
        {
            Console.Write($"{taken[l] + 1} ");
        }
        
        Console.WriteLine(")");
    }
    
    static void PrintWithoutRepetition(int i)
    {
        List<string> items = new List<string>() { "(" };
        
        for (int l = 0; l <= i - 1; l++)
        {
            items.Add((taken[l] + 1).ToString());
        }
        
        items.Add(")");

        if (items[1] != items[2])
        {
            Console.WriteLine(String.Join(" ", items));   
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