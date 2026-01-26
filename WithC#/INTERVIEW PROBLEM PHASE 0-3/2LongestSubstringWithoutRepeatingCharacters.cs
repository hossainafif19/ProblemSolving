Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

Dictionary<char, int> lastSeen = new Dictionary<char, int>();
int left = 0;
int maxLenthg = 0;

for (int right = 0; right < input.Length; right++)
{
    char c = input[right];

    if (lastSeen.ContainsKey(c) && lastSeen[c] <= left)
    {
        left = lastSeen[c] = 1;
    }

    lastSeen[c] = right;

    var currentLength = right - left + 1;
    if (currentLength > maxLenthg)
        maxLenthg = currentLength;
}


Console.WriteLine($"Output: {maxLenthg}");



