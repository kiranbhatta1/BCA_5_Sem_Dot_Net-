using System;

class Program1
{
    static void Main()
    {
        int n, sum = 0;

        Console.Write("Enter Size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Element: ");
            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] % 2 != 0)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine("Sum of Odd Elements = " + sum);
    }
}
