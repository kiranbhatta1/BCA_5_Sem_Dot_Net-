using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(args[0]);
        int num2 = int.Parse(args[1]);

        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));
    }
}
