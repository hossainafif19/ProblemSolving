using System;

class Practice
{
    static void Main()
    {
        Console.Write("Enter n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        for (int i = 2; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
