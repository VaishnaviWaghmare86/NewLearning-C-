using System;

class Program {
    static void Main() {
        int[] nums = {1, 2, 3, 4, 5, 6};

        Console.WriteLine("Even numbers:");
        foreach (int n in nums)
            if (n % 2 == 0) Console.WriteLine(n);

        Console.WriteLine("Odd numbers:");
        foreach (int n in nums)
            if (n % 2 != 0) Console.WriteLine(n);
    }
}
