using System;

Console.WriteLine("Enter a number N:");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int count = 0;
while (input > 0)
{
    input = input / 10;
    count++;
}
Console.WriteLine("Number of digits: " + count);