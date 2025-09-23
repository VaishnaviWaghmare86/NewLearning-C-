using System;

class Program {
    static void Main() {
        int[] nums = {1, 2, 3, 4};
        Array.Reverse(nums);
        foreach (int n in nums)
            Console.WriteLine(n);
    }
}
