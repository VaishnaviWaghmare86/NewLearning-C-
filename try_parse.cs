using System;

class Program {
    static bool CustomTryParse(string input, out int number) {
        try {
            number = Convert.ToInt32(input);
            return true;
        } catch {
            number = 0;
            return false;
        }
    }

    static void Main() {
        if (CustomTryParse("123", out int num))
            Console.WriteLine("Number: " + num);
        else
            Console.WriteLine("Invalid input!");
    }
}

