using CICD_Core;

Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());
double res = Calculator.Divide(a, b);
Console.WriteLine($"{a} / {b} = {res}");
