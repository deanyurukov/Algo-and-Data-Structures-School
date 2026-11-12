namespace NumberMultiplicate_Iterative;

class Program
{
    const int n = 50;
    const int MAXLN = 20;

    static int[] mp = new int[MAXLN];

    static void Print(int length)
    {
        for (int i = 1; i < length; i++)
        {
            Console.Write($"{mp[i]} * ");
        }

        Console.WriteLine(mp[length]);
    }

    static void DevNum()
    {
        int pos = 1;
        int[] remaining = new int[MAXLN];

        mp[0] = n + 1;
        remaining[1] = n;

        while (pos > 0)
        {
            int k = mp[pos] == 0 ? remaining[pos] : mp[pos] - 1;

            bool found = false;

            while (k > 1)
            {
                if (remaining[pos] % k == 0 && k <= mp[pos - 1])
                {
                    mp[pos] = k;
                    remaining[pos + 1] = remaining[pos] / k;

                    if (remaining[pos + 1] == 1)
                    {
                        Print(pos);
                    }
                    else
                    {
                        pos++;
                        mp[pos] = 0;
                        found = true;
                        break;
                    }
                }

                k--;
            }

            if (!found)
            {
                mp[pos] = 0;
                pos--;
            }
        }
    }

    static void Main()
    {
        DevNum();
    }
}