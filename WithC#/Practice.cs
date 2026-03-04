using System.Text;

Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

input += " ";

StringBuilder previousSB = new StringBuilder();
StringBuilder currentSB = new StringBuilder();


foreach (char val in input)
{
    if (!char.IsLetter(val))
    {
        if (previousSB.Length < currentSB.Length)
        {
            previousSB.Clear();
            previousSB.Append(currentSB);
            currentSB.Clear();
        }

        continue;
    }

    currentSB.Append(val);
}



Console.WriteLine(previousSB.ToString());
