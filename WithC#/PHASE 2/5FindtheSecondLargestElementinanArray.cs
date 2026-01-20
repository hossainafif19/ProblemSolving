using System;

Console.WriteLine("Enter size of array N");
int arraysize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Enter element of array");
int[] array = new int[arraysize];
for (int i = 0; i < arraysize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");

int firstLarge = array[0];
int secondLarge = array[0];
for (int i = 0; i < arraysize; i++)
{
    if (array[i] > firstLarge)
    {
        secondLarge = firstLarge;
        firstLarge = array[i];
    }
    else if (firstLarge == secondLarge)
    {
        secondLarge = array[i];
    }
    else if (array[i] > secondLarge && array[i] != firstLarge)
    {
        secondLarge = array[i];
    }
}
Console.WriteLine("");

if (secondLarge != firstLarge)
{
    Console.WriteLine("Second largest element array " + secondLarge);
}
else
{
    Console.WriteLine("No second largest");
}

