// Unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// Integer means negative, positive or zero.
int integerNumber = -23;

// Float means single-precision floating point. Its range is too small for storing all decimal values.
// F suffix makes it a float literal
float realNumber = 2.3F;

// Double means double-precision floating point. Its range is large enough for storing all decimal values.
// Double is the default type for a number value with a d
double anotherRealNumber = 2.3; // double literal

// Three variable that store the numbr 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Check the three variables have the sam value
// Both statements output true
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Exploring Number Types
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}."); // N0 formats the number with commas
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

// Comparing double and decimal types
Console.WriteLine("Using doubles:");

double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal 0.3");
}

Console.WriteLine("Using decimals:");

decimal c = 0.1M; // M suffix makes it a decimal literal
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals 0.3M");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal 0.3M");
}