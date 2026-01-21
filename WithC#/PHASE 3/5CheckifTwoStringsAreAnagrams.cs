Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
string input2 = Console.ReadLine() ?? "";
Console.WriteLine("");

Dictionary<char, int> freq1 = new Dictionary<char, int>();
Dictionary<char, int> freq2 = new Dictionary<char, int>();

foreach (char c in input)
{
    if (c == ' ')
        continue;

    if (freq1.ContainsKey(c))
        freq1[c]++;
    else
        freq1[c] = 1;
}

foreach (char c in input2)
{
    if (c == ' ')
        continue;

    if (freq2.ContainsKey(c))
        freq2[c]++;
    else
        freq2[c] = 1;
}

if (freq1.Count != freq2.Count)
{
    Console.WriteLine("Not Anagram");
    return;
}

foreach (var item in freq1)
{
    if (!freq2.ContainsKey(item.Key))
    {
        Console.WriteLine("Not Anagram");
        return;
    }

    if (freq1[item.Key] != freq2[item.Key])
    {
        Console.WriteLine("Not Anagram");
        return;
    }
}

Console.WriteLine("Anagram");