using System;

class Program {
    static void Main() {
        try {
            int num = int.Parse("abc");
        } catch (Exception ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
