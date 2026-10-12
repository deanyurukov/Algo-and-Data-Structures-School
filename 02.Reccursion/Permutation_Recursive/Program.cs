namespace Permutation_Recursive;

class Program
{
    static int maxN = 100;
    static int n = 3;
    private static bool[] used = new bool[maxN];
    private static int[] mp = new int[maxN];
    
    static void print()
    { 
        int i;
        for (i = 0; i < n; i++)
        {
            Console.Write(mp[i] + 1);
        }

        Console.WriteLine();
    }

    static void permute(int i)
    {
        int k;
        if (i >= n)
        {
            print();
            return;
        }

        for (k = 0; k < n; k++)
        {
            if (!used[k])
            {
                used[k] = true;
                mp[i] = k;
                permute(i + 1);
                used[k] = false;
            }
        }
    }

    static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                used[i] = false;
            }
            
            permute(0);
        }
    }