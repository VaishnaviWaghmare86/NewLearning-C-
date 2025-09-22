using System;

class Program {
    static void Main() {
        string a = "Hello";
        string b = "hello";

        Console.WriteLine(a.Equals(b)); // false
        Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true
    }
}
