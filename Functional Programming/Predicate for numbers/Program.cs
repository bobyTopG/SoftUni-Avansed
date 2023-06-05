int lenght = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action<string[], Predicate<string>> print = (names, mach) =>
{
    foreach (var name in names)
    {
        if (mach(name))
        {
            Console.WriteLine(name);
        }
    }
};

print(names, n => n.Length <= lenght);