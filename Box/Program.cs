namespace Box;
class Program
{
    static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        box.Add(1);
        
        Console.WriteLine(box.Remove());
        box.Add(2);
        box.Add(3);
        box.Add(4);
        Console.WriteLine(box.Remove());
        Console.WriteLine(box.Count);
    }
}

