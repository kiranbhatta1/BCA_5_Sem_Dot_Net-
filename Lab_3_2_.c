using System;

class Program2
{
    static void Main()
    {
        int n;

        Console.Write("Enter Size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[5];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Element: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int min = arr[0], max = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine("Minimum = " + min);
        Console.WriteLine("Maximum = " + max);
    }
}
  
  


































































































































































































