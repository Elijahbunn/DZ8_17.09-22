﻿Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine() ?? "0");
A(n, m);
Console.Write($"{A(n, m)}");
            
static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}