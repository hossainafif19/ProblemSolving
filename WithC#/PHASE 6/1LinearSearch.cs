Console.WriteLine("Enter the size of array");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = new int[arraySize];
Console.WriteLine("Enter the element to array");
for (int i = 0; i < arraySize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.WriteLine("Enter the target");
int target = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = LinearSearch(array, target);

if (result > -1)
    Console.WriteLine("Target found in index = " + result);
else
    Console.WriteLine("Target not found");



int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
            return i;
    }

    return -1;
}

//Time Complexity = O(n)
//Space Complexity = O(1)