using System;

class Program
{
    static void Main()
    {
        int n, i = 1;

        Console.Write("Enter Number: ");
        n = Convert.ToInt32(Console.ReadLine());

    Start:
        if (i <= n)
        {
            Console.WriteLine(i + "^3 = " + (i * i * i));
            i++;
            goto Start;
        }
    }
}
