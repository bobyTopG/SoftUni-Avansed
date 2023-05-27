int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string comand = string.Empty;

Action<int[]> print = (numbers) =>
{
    Console.WriteLine(string.Join(" ", numbers));
};
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
        print(array);
    }
    return array;

};


while ((comand = Console.ReadLine()) != "end")
{
   numbers = aritmetics(numbers, comand);
}




