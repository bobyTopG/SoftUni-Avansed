int[] timeArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] tasksArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> time = new(timeArray);
Stack<int> tasks = new(tasksArray);

int DarthVaderDucky = 0;
int ThorDucky = 0;
int BigBlueRubberDucky = 0;
int SmallYellowRubberDucky = 0;

for (int i = 0; i < timeArray.Length; i++)
{

    int total = time.Peek() * tasks.Peek();
    int currentTask = tasks.Peek();
    while (total > 240)
    {
        time.Enqueue(time.Dequeue());
        currentTask -= 2;
        total = time.Peek() * (currentTask);

    }
    if(total <= 60)
    {
        DarthVaderDucky++;
    }
    else if(total <= 120)
    {
        ThorDucky++;
    }
    else if(total <= 180)
    {
        BigBlueRubberDucky++;
    }
    else if (total <= 240)
    {
        SmallYellowRubberDucky++;
    }
    time.Dequeue();
    tasks.Pop();
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {DarthVaderDucky}\nThor Ducky: { ThorDucky}\nBig Blue Rubber Ducky: {BigBlueRubberDucky}\nSmall Yellow Rubber Ducky: {SmallYellowRubberDucky}");