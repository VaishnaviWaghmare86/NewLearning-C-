using System;

class Student {
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() {
        return $"{Name}, {Age} years old";
    }
}

class Program {
    static void Main() {
        Student s = new Student { Name = "Vaishu", Age = 21 };
        Console.WriteLine(s);
    }
}

