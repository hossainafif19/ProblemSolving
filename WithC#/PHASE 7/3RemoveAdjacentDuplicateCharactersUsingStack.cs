Console.WriteLine("Input");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

char[] stack = new char[input.Length];
int top = -1;

foreach (char c in input)
{
    if (top == -1)
        Push(c);
    else if (c == stack[top])
        Pop();
    else
        Push(c);
}

for (int i = 0; i <= top; i++)
    Console.Write(stack[i]);

void Push(char c)
{
    top++;
    stack[top] = c;
}

void Pop()
{
    top--;
}