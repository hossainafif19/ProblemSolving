using System;
using System.Text;

Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

input += " ";   // sentinel to process last word

StringBuilder currentWord = new StringBuilder();
StringBuilder longestWord = new StringBuilder();

foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        currentWord.Append(c);
    }
    else
    {
        if (currentWord.Length > longestWord.Length)
        {
            longestWord.Clear();
            longestWord.Append(currentWord);
        }

        currentWord.Clear();
    }
}

Console.WriteLine("Output: " + longestWord.ToString());
