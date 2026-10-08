namespace DigestNum_Recursive;

class Program
{
    static void digestNum(int num)
    {
        if (num >= 10)
        {
            digestNum(num / 10);
        }

        Console.WriteLine(num % 10);
    }
    
    static void Main(string[] args)
    {
        int numToPrint  = int.Parse(Console.ReadLine());
        digestNum(numToPrint);
    }
}