short[] array = { 1, 2, 4, 4, 5 };
short target = 3;

short result = LowerBound(array, target);

Console.WriteLine(result);

short LowerBound(short[] arr, short target)
{

    byte left = 0;
    byte right = (byte)(arr.Length - 1);
    short result = -1;

    while (left <= right)
    {
        byte mid = (byte)(left + (right - left) / 2);

        if (arr[mid] >= target)
        {
            result = mid;
            right = (byte)(mid - 1);
        }
        else
            left = (byte)(mid + 1);
    }

    return result;
}

// Time Complexity = O(log n)
// Space Complexity = O(1)