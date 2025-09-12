using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
            Console.WriteLine("Valid number: " + number);
        else
            Console.WriteLine("Invalid input!");
    }
}
