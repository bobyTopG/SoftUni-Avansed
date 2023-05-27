int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string comand = string.Empty;

Func<int[], string, int[]> aritmetics = (array, comand) =>
{
    List<int> newNumbers = new();

    if (comand == "add")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]++;
        }
    }
    else if (comand == "subtract")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]--;
        }
    }
    else if (comand == "multiply")
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= 2;
        }
    }
    else if (comand == "print")
    {
        Print(array);
    }
    return array;

};

static void Print(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

while ((comand = Console.ReadLine()) != "end")
{
   numbers = aritmetics(numbers, comand);
}




