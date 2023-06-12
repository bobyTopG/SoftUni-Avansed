using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

Dictionary<string, int> table = new()
{
    { "salad" ,350 },
    { "soup" , 490},
    {"pasta" , 680 },
    {"steak" , 790 }
};
int counteMeals = 0;
Queue<string> meals = new(Console.ReadLine().Split().ToArray());
Stack<int> calories = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

while(meals.Any() && calories.Any())
{
    if(calories.Peek() - table[meals.Peek()] > 0)
    {
        calories.Push(calories.Pop() - table[meals.Dequeue()]);
        counteMeals++;
    }
    else
    {
        int remind = calories.Pop() - table[meals.Dequeue()];
        counteMeals++;
        if (calories.Any())
            calories.Push(calories.Pop() + remind);
        else
            break;
    }
}

if (!meals.Any())
{
    Console.WriteLine($"John had {counteMeals} meals.");
    Console.WriteLine($"For the next few days, he can eat {string.Join(", " , calories)} calories.");
}
else
{
    Console.WriteLine($"John ate enough, he had {counteMeals} meals.");
    Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
}
//salad soup salad steak
//2500 1800 1500


//pasta soup salad steak pasta steak pasta
//1800 1500
