Console.Write("Enter limit: ");
int limit = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter number1: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter number2: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"{number1} {number2} ");

int number3;
int current = 1;

PrintNumbers(current);

void PrintNumbers(int current)
{
    if (current > limit) return;
    number3 = number1 + number2;
    number1 = number2;
    number2 = number3;
    Console.Write($"{number3} ");
    PrintNumbers(current + 1);
}

