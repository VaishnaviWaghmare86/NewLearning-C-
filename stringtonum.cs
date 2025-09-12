using System;

class Program {
    static void Main() {
        string str = "123";
        int num = Convert.ToInt32(str);
        double d = Convert.ToDouble("12.5");

        Console.WriteLine("Integer: " + num);
        Console.WriteLine("Double: " + d);
    }
}
