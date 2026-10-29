namespace Variate_Iterative;

class Program
{
    const int MAXN = 100;
    const int elements = 4;
    const int numElToLog = 2;

    static int[] taken = new int[MAXN];
    
    static void Print(int i)
    {
        Console.Write("( ");

        for (int j = 0; j < i; j++)
        {
            Console.Write(taken[j] + 1 + " ");
        }
        
        Console.WriteLine(")");
    }
    
    static void VariateWithRepetition(int i)
    {
        for (int j = 0; j < numElToLog; j++)
        {
            taken[j] = 0;
        }

        while (true)
        {
            Print(numElToLog);

            i = numElToLog - 1;

            while (i >= 0 && taken[i] == elements - 1)
            {
                taken[i] = 0;
                i--;
            }

            if (i < 0) break;

            taken[i]++;
        }
    }

    static void VariateWithoutRepetition(int i)
    {
        for (int j = 0; j < numElToLog; j++)
        {
            taken[j] = j;
        }

        while (true)
        {
            Print(numElToLog);

            i = numElToLog - 1;

            while (i >= 0)
            {
                int j;

                for (j = taken[i] + 1; j < elements; j++)
                {
                    bool used = false;

                    for (int l = 0; l < i; l++)
                    {
                        if (taken[l] == j)
                        {
                            used = true;
                            break;
                        }
                    }

                    if (!used) break;
                }

                if (j < elements)
                {
                    taken[i] = j;
                    break;
                }

                i--;
            }

            if (i < 0) break;

            for (int j = i + 1; j < numElToLog; j++)
            {
                for (int candidate = 0; candidate < elements; candidate++)
                {
                    bool used = false;

                    for (int l = 0; l < j; l++)
                    {
                        if (taken[l] == candidate)
                        {
                            used = true;
                            break;
                        }
                    }

                    if (!used)
                    {
                        taken[j] = candidate;
                        break;
                    }
                }
            }
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