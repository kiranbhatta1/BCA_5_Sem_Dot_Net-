using System;

class Program
{
    static void Main()
    {
        int num, sum = 0, temp, rem;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        temp = num;

        while (temp != 0)
        {
            rem = temp % 10;
            sum += rem * rem * rem;
            temp /= 10;
        }

        if (sum == num)
        {
            Console.WriteLine("Armstrong Number");
        }
        else
        {
            Console.WriteLine("Not Armstrong Number");
        }
    }
}
