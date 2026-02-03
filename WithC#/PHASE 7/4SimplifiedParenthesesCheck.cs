// Console.WriteLine("Input:");
// string input = Console.ReadLine() ?? "";
// Console.WriteLine("");

// char[] stack = new char[input.Length];
// int top = -1;

// foreach (char c in input)
// {
//     if (c != '(' && c != ')')
//     {
//         continue;
//     }
//     else if (top == -1)
//     {
//         Push(c);
//     }
//     else if (c == ')' && stack[top] == '(')
//     {
//         Pop();
//     }
//     else
//     {
//         Push(c);
//     }
// }

// if (top == -1)
//     Console.WriteLine("True");
// else
//     Console.WriteLine("False");

// void Push(char c)
// {
//     top++;
//     stack[top] = c;
// }

// void Pop()
// {
//     top--;
// }

/*-------------------------------------------------*/

Console.WriteLine("Input:");
string input = Console.ReadLine() ?? "";
Console.WriteLine("");

char[] stack = new char[input.Length];
int top = -1;

foreach (char c in input)
{
    // ignore everything except '(' and ')'
    if (c != '(' && c != ')')
        continue;

    if (c == '(')
    {
        // push
        top++;
        stack[top] = c;
    }
    else // c == ')'
    {
        // pop
        if (top == -1)
        {
            Console.WriteLine("False");
            return;
        }
        top--;
    }
}

// after processing all characters
if (top == -1)
    Console.WriteLine("True");
else
    Console.WriteLine("False");
