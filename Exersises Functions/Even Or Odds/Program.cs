using System;

Func<int, int, List<int>> Generatrange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }
    return range;
};

Func<int, string, bool> oddOrEven = (num, comand) =>
{
    if (comand == "even")
    {
        return num % 2 == 0;
    }
    else
    {
        return num % 2 != 0;
    }

};


int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string comand = Console.ReadLine();

List<int> nums = Generatrange(numbers[0], numbers[1]);

foreach (var item in nums)
{
    if (oddOrEven(item, comand))
    {
        Console.Write($"{item} ");
    }
}