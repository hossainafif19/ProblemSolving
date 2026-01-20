using System;

Console.WriteLine("Enter size of array N");
int arraysize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
int[] array = new int[arraysize];

Console.WriteLine("Enter the elemen of array");
for (int i = 0; i < arraysize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int storeValue = array[0];

foreach (int i in array)
{
    if (storeValue < i)
    {
        storeValue = i;
    }
}

Console.WriteLine("Large value from the array is " + storeValue);