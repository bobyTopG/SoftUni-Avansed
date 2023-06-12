int[] textileArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] medicamentsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> textile = new(textileArray);
Stack<int> medicaments = new(medicamentsArray);

Dictionary<string, int> dic = new();

while (true)
{
    if (!(textile.Any() && medicaments.Any()))
    {
        break;
    }

    int sum = textile.Peek() + medicaments.Peek();
    
    
    if (sum == 30)
    {
        textile.Dequeue();
        medicaments.Pop();
        if (!dic.ContainsKey("Patch"))
        {
            dic.Add("Patch", 0);
        }
        dic["Patch"]++;
        
    }
    else if(sum == 40)
    {
        textile.Dequeue();
        medicaments.Pop();
        if (!dic.ContainsKey("Bandage"))
        {
            dic.Add("Bandage", 0);
        }
        dic["Bandage"]++;

    }
    else if (sum == 100)
    {
        textile.Dequeue();
        medicaments.Pop();
        if (!dic.ContainsKey("MedKit"))
        {
            dic.Add("MedKit", 0);
        }
        dic["MedKit"]++;

    }
    else if (sum > 100)
    {
        if (!dic.ContainsKey("MedKit"))
        {
            dic.Add("MedKit", 0);
        }
        dic["MedKit"]++;

        sum -= 100;
        
        textile.Dequeue();
        medicaments.Pop();
        medicaments.Push(medicaments.Pop() + sum);

    }
    else
    {
        
        textile.Dequeue();
        medicaments.Push(medicaments.Pop() + 10);
        
    }

}

if (!textile.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textile.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in dic.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}