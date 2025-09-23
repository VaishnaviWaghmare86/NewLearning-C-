using System;

class Program {
    static double Area(double b, double h) {
        return 0.5 * b * h;
    }

    static void Main() {
        Console.WriteLine("Area: " + Area(10, 5));
    }
}
