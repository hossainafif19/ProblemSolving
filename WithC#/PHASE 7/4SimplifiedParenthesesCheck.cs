Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

char[] stack = new char[input.Length];
int top = -1;
Dictionary<char, char> map = new Dictionary<char, char>();
map['('] = ')';
map['{'] = '}';
map['['] = ']';

foreach (char c in input)
{

    if (top == -1)
    {
        Push(c);
    }
    else if ((char.IsLetter(c) || c == ' ') && top != -1)
    {
        //continue;
    }
    else if (c == map[stack[top]])
    {
        Pop();
    }
    else
    {
        Push(c);
    }
}

if (top == -1)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

for (int i = 0; i < stack.Length; i++)
{
    Console.WriteLine(stack[i]);
}

void Push(char c)
{
    top++;
    stack[top] = c;
}

void Pop()
{
    top--;
}