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
    if (c != '(' && c != ')' && c != '{' && c != '}' && c != '{' && c != '}')
        continue;

    if (top == -1)
    {
        top++;
        stack[top] = c;
    }
    else if (!map.ContainsKey(stack[top]))
    {
        top++;
        stack[top] = c;
    }
    else if (c == map[stack[top]])
    {
        top--;
    }
    else
    {
        top++;
        stack[top] = c;
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

/*-------------------------------------------------*/

// Console.WriteLine("Input:");
// string input = Console.ReadLine() ?? "";
// Console.WriteLine("");

// Dictionary<char, char> map = new Dictionary<char, char>
// {
//     { ')', '(' },
//     { '}', '{' },
//     { ']', '[' }
// };

// char[] stack = new char[input.Length];
// int top = -1;

// foreach (char c in input)
// {
//     // Opening brackets → push
//     if (c == '(' || c == '{' || c == '[')
//     {
//         stack[++top] = c;
//     }
//     // Closing brackets → pop & match
//     else if (c == ')' || c == '}' || c == ']')
//     {
//         if (top == -1)
//         {
//             Console.WriteLine("False");
//             return;
//         }

//         if (stack[top] != map[c])
//         {
//             Console.WriteLine("False");
//             return;
//         }

//         top--;
//     }
//     // Ignore other characters
// }

// Console.WriteLine(top == -1 ? "True" : "False");
