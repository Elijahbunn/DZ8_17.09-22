Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;

PrintSum(number);
Console.WriteLine($"The sum of the digits is {sum}");

void PrintSum(int current)
{
    if (current == 0) return;
    sum += current % 10;
    PrintSum(current / 10);
}