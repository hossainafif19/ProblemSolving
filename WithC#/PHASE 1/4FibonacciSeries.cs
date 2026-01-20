using System;

Console.WriteLine("Enter a number N");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int fN1 = 0;
int fN2 = 1;

Console.WriteLine(fN1);
Console.WriteLine(fN2);
while (input > 2)
{
    Console.WriteLine(fN1 + fN2);
    var fN = fN1 + fN2;
    fN1 = fN2;
    fN2 = fN;

    input--;
}
