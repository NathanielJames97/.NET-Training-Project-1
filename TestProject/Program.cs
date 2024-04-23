using System;

class Program
{
    static void Main(string[] args)
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue;

        largerValue = Math.Max(firstValue, secondValue); // Assign the larger value using Math.Max

        Console.WriteLine(largerValue); // Output: 600
    }
}