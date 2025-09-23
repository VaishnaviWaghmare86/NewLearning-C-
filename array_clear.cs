using System;

class Program {
    static void Main() {
        int[] nums = {1, 2, 3, 4};
        Array.Clear(nums, 1, 2);
        foreach (int n in nums)
            Console.WriteLine(n);
    }
}
