string[] names = Console.ReadLine().Split().ToArray();

Action<string[]> output = (string[] names) =>
Console.WriteLine(string.Join(Environment.NewLine, names));