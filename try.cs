using System;

class Program {
    static void Main() {
        try {
            int[] arr = {1, 2};
            Console.WriteLine(arr[5]);
        } catch (IndexOutOfRangeException e) {
            Console.WriteLine("Caught exception: " + e.Message);
        }
    }
}
