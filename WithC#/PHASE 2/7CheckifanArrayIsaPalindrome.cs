Console.WriteLine("Enter size of array N");
int arraysize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Enter element of array");
int[] array = new int[arraysize];
for (int i = 0; i < arraysize; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");

int middle = arraysize / 2;
bool isPalindrome = true;
for (int i = 0; i < middle; i++)
{
    int last = arraysize - 1 - i;
    if (array[i] != array[last])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}