List<Person> people = new();
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tocken = Console.ReadLine().Split(", ").ToArray();
    string name = tocken[0];
    int age = int.Parse(tocken[1]);

    people.Add(new Person() {Age = age, Name = name });
}

string youngOrOld = Console.ReadLine();
int ageFilter = int.Parse(Console.ReadLine());
string condition = Console.ReadLine();

Func<Person, bool> filter = GetFilter(youngOrOld, ageFilter);

people = people.Where(filter).ToList();
Action<Person> printer = Printer(condition);


foreach (var person in people)
{
    printer(person);
}

Action<Person> Printer(string condition)
{
    switch (condition)
    {
        case "name age":return p =>
        Console.WriteLine($"{p.Name} - {p.Age}");

        case "name": return p =>
        Console.WriteLine($"{p.Name}");

        case "age": return p =>
        Console.WriteLine($"{p.Age}");

        default:return null;
        
    }
}

Func<Person, bool> GetFilter(string youngOrOld, int ageFilter)
{
    switch (youngOrOld)
    {
        case "younger": return person => person.Age < ageFilter;
        case "older": return person => person.Age >= ageFilter;

        default:
            return null;
    }
       
}

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
   
}