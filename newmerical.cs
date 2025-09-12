using System;

class NumericalDataTypesDemo
{
    static void Main(string[] args)
    {
        // Integral types
        byte b1 = 255;                  // 8-bit unsigned
        sbyte b2 = -128;                // 8-bit signed
        short s1 = -32000;              // 16-bit signed
        ushort s2 = 65000;              // 16-bit unsigned
        int i1 = -2000000000;           // 32-bit signed
        uint i2 = 4000000000;           // 32-bit unsigned
        long l1 = -9000000000000000000; // 64-bit signed
        ulong l2 = 18000000000000000000; // 64-bit unsigned

        // Floating-point types
        float f1 = 3.1415927f;          // 32-bit float
        double d1 = 3.141592653589793;  // 64-bit double
        decimal dec1 = 79228162514264337593543950335m; // 128-bit decimal (high precision)

        Console.WriteLine("----- Numerical Data Types in C# -----");

        // Integral
        Console.WriteLine("byte   : " + b1);
        Console.WriteLine("sbyte  : " + b2);
        Console.WriteLine("short  : " + s1);
        Console.WriteLine("ushort : " + s2);
        Console.WriteLine("int    : " + i1);
        Console.WriteLine("uint   : " + i2);
        Console.WriteLine("long   : " + l1);
        Console.WriteLine("ulong  : " + l2);

        // Floating-point
        Console.WriteLine("float  : " + f1);
        Console.WriteLine("double : " + d1);
        Console.WriteLine("decimal: " + dec1);
    }
}
