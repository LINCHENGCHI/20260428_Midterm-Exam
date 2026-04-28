using System;

class Person
{
    public string name;

    public Person() => name = "Person";

    public Person(string name) => this.name = name;
}

class Student : Person
{
    public Student() : base() { }

    public Student(string name) : base(name) { }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(new Person().name);
        Console.WriteLine(new Person("New Person").name);
        Console.WriteLine(new Student().name);
        Console.WriteLine(new Student("New Student").name);
    }
}