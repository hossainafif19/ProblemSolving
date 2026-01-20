using System;

Console.WriteLine("Enter the size of array");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Enter Array Element");
int[] array = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int middle = arraySize / 2;

for (int i = 0; i < middle; i++)
{
    var store = array[i];
    var lastIndex = (arraySize - 1) - i;
    array[i] = array[lastIndex];
    array[lastIndex] = store;
}

Console.WriteLine("");
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine(array[i]);
}