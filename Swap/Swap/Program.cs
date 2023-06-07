List<string> list = new();



int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string comand = Console.ReadLine();
    list.Add(comand);
}
int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
Swap(indexes[0], indexes[1], list);
static void Swap<T>(int index1 , int index2 , List<T> items)
{
    var first = items[index1];
    var secound = items[index2];
    items[index2] = first;
    items[index1] = secound;

}
foreach (var item in list)
{
    Console.WriteLine(item);
}