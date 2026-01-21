Console.WriteLine("Enter a string");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

int vowels = 0;
int consonants = 0;

foreach (char c in input)
{
    if (('A' <= c && c <= 'Z') || ('a' <= c && c <= 'z'))
    {
        char ch = char.ToLower(c);
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u': vowels++; break;
            default: consonants++; break;
        }
    }
}

Console.WriteLine("Vowels =" + vowels);
Console.WriteLine("Consonants =" + consonants);