string[] kings = Console.ReadLine().Split().ToArray();

Action<string> print = PrintWords();
Action<string> PrintWords()
{
    return x => Console.WriteLine(x);
}

foreach (var item in kings)
{
    print("Sir " + item);
}
