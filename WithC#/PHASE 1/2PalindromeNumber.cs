using System;

Console.WriteLine("Enter a number N");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int value = input;
int reverseNumber = 0;
while (value > 0)
{
    int mod = value % 10;
    value = value / 10;
    reverseNumber = reverseNumber * 10 + mod;
}

if (reverseNumber == input)
{
    Console.WriteLine("This number is a palindrome");
}
else
{
    Console.WriteLine("This number is not a palindrome");
}