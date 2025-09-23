using System;

class Program {
    static void Main() {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (password == "admin123")
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");
    }
}
