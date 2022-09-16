Console.Write("Enter N : ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter M : ");
int M = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
PrintNumber(N);
Console.Write($"Sum of interval from N to M: {sum} ");

void PrintNumber(int N)
{
    if (N > M) return;
    sum += N;
    PrintNumber(N + 1);
}