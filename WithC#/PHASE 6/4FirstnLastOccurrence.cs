int[] array = new int[] { 1, 2, 2, 2, 3, 4 };
int target = 2;

int f = FirstOccurrence(array, target);
Console.WriteLine("First index: " + f);
int l = LastOccurrence(array, target);
Console.WriteLine("Last index: " + l);
Console.WriteLine("Total count: " + (l - f + 1));

int FirstOccurrence(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;
    int result = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            result = mid;

        if (arr[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return result;
}

int LastOccurrence(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;
    int result = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            result = mid;

        if (arr[mid] <= target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return result;
}