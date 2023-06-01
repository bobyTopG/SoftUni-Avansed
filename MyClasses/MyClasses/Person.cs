﻿namespace SoftUniParking
{
    public class Person
    {
        private string name;
        private int age;

        public Person() { }
        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }


        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }

    }
}