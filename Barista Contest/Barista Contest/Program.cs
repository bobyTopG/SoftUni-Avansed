int[] cofeeArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] milkArray = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> cofee = new Queue<int>(cofeeArray);
Stack<int> milk = new Stack<int>(milkArray);
Dictionary<string, int> dic = new();

while (cofee.Any() && milk.Any())
{
    int sum = cofee.Dequeue() + milk.Peek();

    if(sum == 50)
    {
        if (!dic.ContainsKey("Cortado"))
        {
            dic.Add("Cortado", 0);
        }
        dic["Cortado"]++;
        milk.Pop();
    }
    else if (sum == 75)
    {
        if (!dic.ContainsKey("Espresso"))
        {
            dic.Add("Espresso", 0);
        }
        dic["Espresso"]++;
        milk.Pop();
    }
    else if (sum == 100)
    {
        if (!dic.ContainsKey("Capuccino"))
        {
            dic.Add("Capuccino", 0);
        }
        dic["Capuccino"]++;
        milk.Pop();
    }
    else if (sum == 150)
    {
        if (!dic.ContainsKey("Americano"))
        {
            dic.Add("Americano", 0);
        }
        dic["Americano"]++;
        milk.Pop();
    }
    else if (sum == 200)
    {
        if (!dic.ContainsKey("Latte"))
        {
            dic.Add("Latte", 0);
        }
        dic["Latte"]++;
        milk.Pop();
    }
    else
    {
        milk.Push(milk.Pop() - 5);
    }
    

}


if(!cofee.Any() && !milk.Any())
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}

if (!cofee.Any())
{
    Console.WriteLine("Coffee left: none");
}
else
{
    Console.WriteLine($"Coffee left: {string.Join(" " , cofee)}");
}

if (!milk.Any())
{
    Console.WriteLine("Milk left: none");
}
else
{
    Console.WriteLine($"Milk left: {string.Join(" ", milk)}");
}

foreach (var (name , count) in dic.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key))
{
    Console.WriteLine($"{name}: {count}");
}


