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

int lastIndex = array[0];
bool isSorted = true;
foreach (int i in array)
{
    if (i < lastIndex)
    {
        isSorted = false;
        break;
    }
    lastIndex = i;
}

if (isSorted)
{
    Console.WriteLine("Sorted");
}
else
{
    Console.WriteLine("Not Sorted");
}