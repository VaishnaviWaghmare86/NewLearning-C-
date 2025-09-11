using System;
using System.Text;
using System.Globalization;

class DataTypesDemo
{
    static void Main(string[] args)
    {
        int age = 21;
        float pi = 3.14f;
        double price = 199.99;
        char grade = 'A';
        string name = "Vaishu";
        bool isStudent = true;
        long population = 1400000000;
        decimal salary = 45230.75m;
        byte level = 255;
        short smallNumber = 32000;

        Console.WriteLine("----- Data Types in C# -----");
        Console.WriteLine("Integer (age): " + age);
        Console.WriteLine("Float (pi): " + pi);
        Console.WriteLine("Double (price): " + price);
        Console.WriteLine("Char (grade): " + grade);
        Console.WriteLine("String (name): " + name);
        Console.WriteLine("Boolean (isStudent): " + isStudent);
        Console.WriteLine("Long (population): " + population);
        Console.WriteLine("Decimal (salary): " + salary);
        Console.WriteLine("Byte (level): " + level);
        Console.WriteLine("Short (smallNumber): " + smallNumber);
    }
}
