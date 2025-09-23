using System;

class Program {
    static void Main() {
        int[] nums = {5, 3, 8, 1};
        Array.Sort(nums);
        foreach (int n in nums)
            Console.WriteLine(n);
    }
}
