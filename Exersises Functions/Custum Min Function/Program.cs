HashSet<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToHashSet();

Func<HashSet<int> , int> min = x => x.Min();
Console.WriteLine(min(numbers));

