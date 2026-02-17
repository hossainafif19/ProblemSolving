int[] array = new int[] { 1, 2, 3, 2, 4, 2 };
int target = 2;
int result = CountOccurrences(array, target);
Console.WriteLine(result);



int CountOccurrences(int[] arr, int target)
{
    int count = 0;
    foreach (int i in arr)
        if (i == target)
            count++;

    return count;
}

//Time Complexity = O(n)
//Space Complexity = O(1)