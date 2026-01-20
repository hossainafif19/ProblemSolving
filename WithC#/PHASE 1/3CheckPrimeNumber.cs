using System;

Console.WriteLine("Enter a numer N");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (input < 2)
{
    Console.WriteLine("The number is not prime!");
    return;
}

bool isPrime = true;
for (int i = 2; i < input; i++)
{
    if (input % i == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime)
{
    Console.WriteLine("This is a prime number!");
}
else
{
    Console.WriteLine("The number is not prime!");
}
