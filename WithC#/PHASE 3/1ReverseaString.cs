// Console.WriteLine("Enter a string");
// string input = Console.ReadLine() ?? "";
// Console.WriteLine("");

// string output = "";

// for (int i = input.Length - 1; i >= 0; i--)
// {
//     output += input[i];
// }

// Console.WriteLine(output);

Console.WriteLine("Enter a string");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

char[] chars = input.ToCharArray();
int left = 0;
int right = chars.Length - 1;

while (left < right)
{
    char temp = chars[left];
    chars[left] = chars[right];
    chars[right] = temp;

    left++;
    right--;
}

Console.WriteLine(new string(chars));
