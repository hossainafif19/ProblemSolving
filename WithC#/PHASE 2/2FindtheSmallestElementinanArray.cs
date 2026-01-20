using System;

Console.WriteLine("Enter the size of array N");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[] array = new int[input];
Console.WriteLine("Enter array elements");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");

int storeValue = array[0];
foreach (int i in array)
{
    if (storeValue > i)
        storeValue = i;
}

Console.WriteLine(storeValue + " is the smallest element in an array!");