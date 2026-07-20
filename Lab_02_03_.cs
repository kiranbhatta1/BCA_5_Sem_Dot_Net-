using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.Write("Enter the first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        c = Convert.ToInt32(Console.ReadLine());

        // Nested If-Else
        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("Largest: " + a);
            }
            else
            {
                Console.WriteLine("Largest: " + c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("Largest: " + b);
            }
            else
            {
                Console.WriteLine("Largest: " + c);
            }
        }
    }
}
                  
                    
                    
                  
