// See https://aka.ms/new-console-template for more information
void CalculateNumbers(int var1, int var2)
{
    int sum = var1 + var2;
    int diff = var1 - var2;
    int prod = var1 * var2;
    double div = (double)var1 / var2;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {diff}");
    Console.WriteLine($"Product: {prod}");
    Console.WriteLine($"Division: {div}");
}
