using DefiningClasses;
using System;

public class StartUp
{
    static void Main(string[] args)
    {

        List<Person> family = new();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            Person person = new Person(tokens[0], int.Parse(tokens[1]));
            if (person.Age > 30)
            {    
                family.Add(person);
            }
            
        }
        foreach (Person item in family.OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
        
    }
}