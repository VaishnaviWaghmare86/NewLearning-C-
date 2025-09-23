using System;

class Program {
    static void Main() {
        string word = "Vaishu";
        for (int i = word.Length - 1; i >= 0; i--) {
            Console.Write(word[i]);
        }
    }
}
