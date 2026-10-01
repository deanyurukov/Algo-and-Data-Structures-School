namespace  Factorial;

class Program
{
    static int Factorial(int n, int current, int sum)
    {
        if (current == 0) 
        {
            return sum;
        }
        
        sum *= current;
        --current;
        
        return Factorial(n, current, sum);
    }
    
    static void Main(string[] args)
    {
        int factorialOf5 = Factorial(5, 5, 1);
        int factorialOf10 = Factorial(10, 10, 1);

        Console.WriteLine(factorialOf5);
        Console.WriteLine(factorialOf10);
    }
}