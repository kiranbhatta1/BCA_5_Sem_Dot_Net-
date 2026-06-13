using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double f = (c * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit: " + f);
    }
}
                
