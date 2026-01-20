using System;

Console.WriteLine("Enter a number N:");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int reversedNumber = 0;
while (input > 0)
{
    int mod = input % 10;
    input = input / 10;
    reversedNumber = reversedNumber * 10 + mod;
}

Console.WriteLine("The reverce number is:" + reversedNumber);