namespace PowerOfTen;

class Program
{
    static void getPower(int num, int max)
    {
        Console.WriteLine(num);
        
        if (num < max)
        {
            getPower(num * 10, max);
        }

        Console.WriteLine(num);
    }
    
    static void Main(string[] args)
    {
        int powerOfTen = int.Parse(Console.ReadLine());
        int maxNumber = (int) Math.Pow(10, powerOfTen);
        getPower(10, maxNumber);
    }
}