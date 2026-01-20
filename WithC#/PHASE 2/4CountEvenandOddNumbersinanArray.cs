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

int evenCount = 0;
int oddCount = 0;

int middle = arraysize / 2;
int modElement = arraysize % 2;

for (int i = 0; i < arraysize; i++)
{
    if (array[i] % 2 == 0)
        evenCount++;
    else
        oddCount++;
}

Console.WriteLine($"Even count = {evenCount} Odd count = {oddCount}");
