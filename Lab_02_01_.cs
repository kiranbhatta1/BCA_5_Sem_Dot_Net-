using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        Console.WriteLine("Enter three numbers:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

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
                  

