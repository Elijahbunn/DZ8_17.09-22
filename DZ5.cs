Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter degree: ");
int degree = int.Parse(Console.ReadLine() ?? "0");
int product = 1;
int current = 1;
PrintProduct(current);
Console.Write($"Final number: {product} ");


void PrintProduct(int current)
{
    if (current > degree) return;
    product = product * number;
    PrintProduct(current + 1);
}