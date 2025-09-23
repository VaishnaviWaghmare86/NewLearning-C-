using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<int, string> students = new Dictionary<int, string>();
        students[1] = "Vaishu";
        students[2] = "Apurva";

        foreach (var pair in students)
            Console.WriteLine(pair.Key + " => " + pair.Value);
    }
}
