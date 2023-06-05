int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Reverse()
    .ToArray();
int divisible = int.Parse(Console.ReadLine());

Func<int,int,bool> IsDivisible = (num, divisible) =>
{
    return num % divisible != 0;
};

foreach (var num in numbers)
{
    if(IsDivisible(num , divisible))
    {
        Console.Write($"{num} ");
    }
}