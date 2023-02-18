// Unary Arithmetic Operators:

// Postfix increment operator
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

// Prefix increment operator
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

// Postfix decrement operator
int e = 3;
int f = e--;
WriteLine($"e is {e}, f is {f}");

// Prefix decrement operator
int g = 3;
int h = --g;
WriteLine($"g is {g}, h is {h}");

// Binary Arithmetic Operators:

int i = 11;
int j = 3;
WriteLine($"i is {i}, j is {j}");
WriteLine($"i + j = {i + j}");
WriteLine($"i - j = {i - j}");
WriteLine($"i * j = {i * j}");
WriteLine($"i / j = {i / j}");
WriteLine($"i % j = {i % j}");

double k = 11.0;
WriteLine($"k is {k:N1}, j is {j}");
WriteLine($"k / j = {k / j}");

// Assignment Operators:

int l = 7;
l += 3; // l = l + 3
l -= 3; // l = l - 3
l *= 3; // l = l * 3
l /= 3; // l = l / 3