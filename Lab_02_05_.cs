using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a Number:");
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("The Number is Prime.");
        }
        else
        {
            Console.WriteLine("The Number is Not Prime.");
        }
    }
}
    
        
