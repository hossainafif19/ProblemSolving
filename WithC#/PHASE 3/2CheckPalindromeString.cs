Console.WriteLine("Enter a string");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

int left = 0;
int right = input.Length - 1;
bool isPalindrome = true;

while (left < right)
{
    if (input[left] != input[right])
    {
        isPalindrome = false;
        break;
    }
    left++;
    right--;
}

if (isPalindrome)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}