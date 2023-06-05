using System;
namespace DefiningClasses
{
	public class Family
	{
		private List<Person> family;

		public Family()
		{
			family = new List<Person>();
		}

        public void AddMember(Person mamber)
		{
			family.Add(mamber);
		}

       public Person GetOldestMember()
		{
			return this.family.MaxBy(x => x.Age);
		}

    }
}

