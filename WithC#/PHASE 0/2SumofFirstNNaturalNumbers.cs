using System;

Console.WriteLine("Enter a number N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);