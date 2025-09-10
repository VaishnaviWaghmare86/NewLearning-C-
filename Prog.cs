using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the First Number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the Second Number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("The sum is: " + sum);
    }
}
