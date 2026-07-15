using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Length:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Breadth:");
        double breadth = Convert.ToDouble(Console.ReadLine());

        double area = length * breadth;
        double perimeter = 2 * (length + breadth);

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}
