Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

Dictionary<char, int> frq = new Dictionary<char, int>();

foreach (char c in input)
{
    if (c == ' ')
        continue;

    if (frq.ContainsKey(c))
        frq[c]++;
    else
        frq[c] = 1;
}

foreach (char c in input)
{
    if (c == ' ')
        continue;

    if (frq[c] == 1)
    {
        Console.WriteLine("Output: " + c);
        return;
    }
}

Console.WriteLine("Output: None");