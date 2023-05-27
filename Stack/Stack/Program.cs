string input = Console.ReadLine();
Stack<int> index = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        index.Push(i);
    }
    else if(input[i] == ')')
    {
        int indexOfOpenBracket = index.Pop();

        for (int j = indexOfOpenBracket; i >= j; j++)
        {
            Console.Write(input[j]);
        }
        Console.WriteLine();
    }
}