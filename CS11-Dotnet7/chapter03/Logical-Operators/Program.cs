bool a = true;
bool b = false;
WriteLine($"AND  | a     | b    ");
WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR   | a     | b    ");
WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR  | a     | b    ");
WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine(); 
WriteLine($"b & DoStuff() = {b & DoStuff()}");

WriteLine();
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine(); 
WriteLine($"b && DoStuff() = {b && DoStuff()}");

// Conditional logical operators:

static bool DoStuff()
{
    WriteLine("Doing stuff...");
    WriteLine();
    return true;
}