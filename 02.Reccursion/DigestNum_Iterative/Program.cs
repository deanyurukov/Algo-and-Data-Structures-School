namespace DigestNum_Iterative;

class Program
{
    static void Main(string[] args)
    {
        int numToPrint  = int.Parse(Console.ReadLine());
        List<int> digits = new List<int>();

        while (numToPrint >= 10)
        {
            digits.Add(numToPrint % 10);
            numToPrint /= 10;
        }
        
        digits.Add(numToPrint);
        digits.Reverse();
        
        Console.WriteLine(String.Join("\n", digits));
    }
}