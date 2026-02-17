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

int result = BinarySearch(array, target);

if (result > -1)
    Console.WriteLine("Target found in index = " + result);
else
    Console.WriteLine("Target not found");

int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left - (right - left) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}

//Time Complexity = O(log n)
//Space Complexity = O(1)