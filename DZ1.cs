Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
PrintNumber(N);
Console.WriteLine();

void PrintNumber(int N)
{
    if (N > M) return;
    Console.Write($"{N} ");
    PrintNumber(N + 1);
}