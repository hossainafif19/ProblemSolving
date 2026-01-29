Console.WriteLine("Input:");
string input = Console.ReadLine();
Console.WriteLine("");

int top = -1;
char[] stack = new char[input.Length];
Push();
Pop();

bool IsEmpty()
{
    if (top == -1)
        return true;
    else
        return false;
}

void Push()
{
    foreach (char c in input)
    {
        top++;
        stack[top] = c;
    }
}

void Pop()
{
    while (!IsEmpty())
    {
        Console.Write(stack[top]);
        top--;
    }
}