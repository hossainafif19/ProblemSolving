int[] stack = new int[1];
int top = -1;
Start();


void Start()
{
    Console.WriteLine("Welcome to stack problem!");
    Console.WriteLine("Press 1 to see is the stack empty?");
    Console.WriteLine("Press 2 to see push in stack");
    Console.WriteLine("Press 3 to see the top element of array");
    Console.WriteLine("Press 4 to see pop in stack");
    Console.WriteLine("Press 5 to see all in stack");
    Console.WriteLine("");
    Console.WriteLine("Please enter your option");
    int inpput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    switch (inpput)
    {
        case 1: IsEmpty(); break;
        case 2: Push(); break;
        case 3: Peek(); break;
        case 4: Pop(); break;
        case 5: ReadAll(); break;
        default: break;
    }

    Console.WriteLine("");
    Start();
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
        foreach (int i in stack)
        {
            Console.Write(i + ",");
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
        int[] temp = new int[top];
        for (int i = 0; i < top; i++)
            temp[i] = stack[i];

        stack = temp;
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
    int newSize = top + 2;
    int[] temp = new int[newSize];
    for (int i = 0; i < newSize - 1; i++)
        temp[i] = stack[i];
    top += 1;
    temp[top] = Convert.ToInt32(Console.ReadLine());
    stack = temp;
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
