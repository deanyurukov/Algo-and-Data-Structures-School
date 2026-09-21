namespace EgyptionFraction;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter nominator:");
        int nominator = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter denominator:");
        int denominator = int.Parse(Console.ReadLine());
        double result = (double)nominator / denominator;
        int possDenominator = 2;

        while (result != 0)
        {
            while (true)
            {
                double numToAdd = (double)1 / possDenominator;
                
                if (numToAdd < result)
                {
                    Console.WriteLine($"1 / {possDenominator}");
                    result -= numToAdd;

                    if (result < 0.000000000001) result = 0;
                    
                    break;
                }
                
                possDenominator++;
            }

            possDenominator = 2;
        }
    }
}