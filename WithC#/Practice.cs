//!               0  1  3  3  4  5  6  7
short[] array = { 2, 2, 4, 4, 4, 6, 6, 8 };
short target = 6;

short upperResult = UpperBound(array, target);
Console.WriteLine("Upper: " + upperResult);

short lowerResult = LowerBound(array, target);
Console.WriteLine("Lower: " + lowerResult);

short UpperBound(short[] arr, short target)
{
    byte left = 0;
    byte right = (byte)(arr.Length - 1);
    short result = (short)(array.Length);

    while (left <= right)
    {
        byte mid = (byte)(left + (right - left) / 2);

        if (arr[mid] > target)
        {
            result = mid;
            right = (byte)(mid - 1);
        }
        else
            left = (byte)(mid + 1);

    }

    return result;
}

short LowerBound(short[] arr, short target)
{
    byte left = 0;
    byte right = (byte)(arr.Length - 1);
    short result = (short)(array.Length);

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