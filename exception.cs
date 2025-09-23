using System;

class Program {
    static void Main() {
        try {
            int x = 10, y = 0;
            Console.WriteLine(x / y);
        } catch {
            Console.WriteLine("Error occurred!");
        }
    }
}
