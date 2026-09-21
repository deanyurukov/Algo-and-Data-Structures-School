namespace MoneyGet;

public class Program
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>() { 50, 20, 10, 5, 2, 1 };
        int numToGet = int.Parse(Console.ReadLine());

        int initial = numToGet;

        while (initial > 0)
        {
            foreach (int number in values)
            {
                if (initial >= number)
                {
                    Console.WriteLine(number);
                    initial -= number;
                    break;
                }
            }
        }
    }
}