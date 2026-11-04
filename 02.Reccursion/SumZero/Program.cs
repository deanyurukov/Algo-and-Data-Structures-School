namespace SumZero;

class Program
{
    const int n = 8;
    static int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
    static char[] operations = new char[n - 1];
    static int target;

    static void CheckSol()
    {
        long result = a[0];
        long currentTerm = a[0];

        for (int i = 0; i < n - 1; i++)
        {
            if (operations[i] == '+')
            {
                result += currentTerm;
                currentTerm = a[i + 1];
            }
            else if (operations[i] == '-')
            {
                result += currentTerm;
                currentTerm = -a[i + 1];
            }
            else if (operations[i] == '*')
            {
                currentTerm *= a[i + 1];
            }
        }

        result += currentTerm;

        if (result == target)
        {
            Console.Write(a[0]);

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($" {operations[i]} {a[i + 1]}");
            }

            Console.WriteLine($" = {result - 1}");
        }
    }

    static void Variate(int i)
    {
        if (i >= n - 1)
        {
            CheckSol();
            return;
        }

        operations[i] = '+';
        Variate(i + 1);

        operations[i] = '-';
        Variate(i + 1);

        operations[i] = '*';
        Variate(i + 1);
    }

    static void Main()
    {
        target = 1;
        Variate(0);
    }
}