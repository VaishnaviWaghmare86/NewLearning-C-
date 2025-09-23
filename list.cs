using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> names = new List<string>() {"A", "B", "C"};
        names.Add("D");

        foreach (string name in names)
            Console.WriteLine(name);
    }
}
