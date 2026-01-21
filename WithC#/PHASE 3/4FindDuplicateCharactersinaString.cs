Console.WriteLine("Enter a string");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

Dictionary<char, int> freq = new Dictionary<char, int>();

foreach (char c in input)
{
    if (c == ' ')
        continue;

    if (freq.ContainsKey(c))
        freq[c]++;
    else
        freq[c] = 1;
}

foreach (var item in freq)
{
    if (item.Value > 1)
        Console.WriteLine(item.Key);
}