Console.WriteLine("Enter the size of array");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[] stack = new int[arraySize];
int top = -1;

while (true)
{
    Console.WriteLine("Welcome to stack problem!");
    Console.WriteLine("Press 1 to see is the stack empty?");
    Console.WriteLine("Press 2 to see push in stack");
    Console.WriteLine("Press 3 to see the top element of array");
    Console.WriteLine("Press 4 to see pop in stack");
    Console.WriteLine("Press 5 to see all in stack");
    Console.WriteLine("Press 0 to exit");
    Console.WriteLine("");
    Console.WriteLine("Please enter your option");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    switch (input)
    {
        case 1: IsEmpty(); break;
        case 2: Push(); break;
        case 3: Peek(); break;
        case 4: Pop(); break;
        case 5: ReadAll(); break;
        case 0: return;
        default: break;
    }

    Console.WriteLine("");
}

void ReadAll()
{
    if (top == -1)
    {
        Console.WriteLine("The array is empty");
    }
    else
    {
        Console.WriteLine("All stack element:");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(stack[i] + ",");
        }
    }
    Console.WriteLine("");

}

void Pop()
{
    if (top == -1)
    {
        Console.WriteLine("The array is empty");
    }
    else
    {
        Console.WriteLine("Popped value:" + stack[top]);
        top--;
    }
}

void Peek()
{
    if (top == -1)
    {
        Console.WriteLine("The array is empty");
    }
    else
    {
        Console.WriteLine("Top element of array: " + stack[top]);
    }
}

void Push()
{
    Console.WriteLine("Enter the number to push in stack:");
    if (top == stack.Length - 1)
    {
        Console.WriteLine("Stack is full");
        return;
    }
    int input = Convert.ToInt32(Console.ReadLine());
    top++;
    stack[top] = input;
}

void IsEmpty()
{
    if (top == -1)
    {
        Console.WriteLine("The array is empty");
    }
    else
    {
        Console.WriteLine("The array is not empty");
    }
}
