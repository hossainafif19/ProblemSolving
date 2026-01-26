Console.WriteLine("Enter Size of array N");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Enter the array elements:");
int[] array = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter Two Sum Target:");
int targat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Dictionary<int, int> freq = new Dictionary<int, int>();

for (int i = 0; i < arraySize; i++)
{
    freq[array[i]] = i;
}

for (int i = 0; i < arraySize; i++)
{
    int needed = targat - array[i];
    if (freq.ContainsKey(needed) && i != freq[needed])
    {
        Console.WriteLine($"[{i},{freq[needed]}]");
        return;
    }
}

Console.WriteLine("No value found to make the target");

/*
Answer in words
inside array processing loop i will check array current value - target = contain in dictionary, 
if not the value and index into dictionary  

✅ Your Answer (Refined Interview Version)

“In the one-pass solution, while iterating through the array,
for each element I calculate needed = target - currentValue.

I first check if needed already exists in the dictionary.
If it does, I return the stored index and the current index.

If it does not exist, I store the current value with its index in the dictionary
and continue.”
*/