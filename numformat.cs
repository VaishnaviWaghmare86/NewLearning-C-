using System;

class Program {
    static void Main() {
        double price = 1234.567;

        Console.WriteLine(price.ToString("C"));  // Currency
        Console.WriteLine(price.ToString("F2")); // 2 decimal places
    }
}
