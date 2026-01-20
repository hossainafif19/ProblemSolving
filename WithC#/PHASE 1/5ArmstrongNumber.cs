using System;

Console.WriteLine("Enter a number N");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int value = input;
int count = 0;
int output = 0;
while (value > 0)
{
    value = value / 10;
    count++;
}
value = input;
while (value > 0)
{
    int mod = value % 10;
    int multiplication = 1;
    for (int i = 0; i < count; i++)
    {
        multiplication = multiplication * mod;
    }
    output = output + multiplication;
    value = value / 10;
}

if (output == input)
{
    Console.WriteLine("This is Armstrong Number");
}
else
{
    Console.WriteLine("This is not Armstrong Number");
}