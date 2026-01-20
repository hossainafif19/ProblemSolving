using System;

Console.WriteLine("Enter a number N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
if (n % 2 == 0)
{
    Console.WriteLine(n + " is even.");
}
else
{
    Console.WriteLine(n + " is odd.");
}
Console.WriteLine("");