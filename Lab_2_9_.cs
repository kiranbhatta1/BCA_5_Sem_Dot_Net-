using System;

class Program
{
    static void Main()
    {
        int num, sum = 0;

        do
        {
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
                sum += num;

        } while (num >= 0);

        Console.WriteLine("Sum = " + sum);
    }
}
