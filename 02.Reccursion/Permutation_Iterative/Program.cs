namespace Permutation_Iterative;

class Program
{
    static void permute(List<char> arr)
    {
        List<char> initial = new List<char>(arr);
        List<char> current = new List<char>(initial);

        Console.WriteLine(string.Join(" ", initial));

        while (!current.SequenceEqual(initial.AsEnumerable().Reverse()))
        {
            for (int i = current.Count - 1; i >= 1; i--)
            {
                char prev = current[i - 1];

                if (prev != '\0' && prev < current[i])
                {
                    List<char> rest = current.Skip(i - 1).ToList();
                    current = current.Take(i - 1).ToList();

                    rest.Sort();

                    int j = rest.FindIndex(element => element > prev);
                    char smallest = rest[j];

                    rest.RemoveAt(j);
                    current.Add(smallest);
                    current.AddRange(rest);

                    Console.WriteLine(string.Join(" ", current));
                    break;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        List<char> arr = new List<char> { '1', '2', '3' };
        permute(arr);
    }
}