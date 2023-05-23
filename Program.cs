// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Insert a number for calculate the factorial of this number");
var n_value = Console.ReadLine();

if (n_value != null)
{
    int n = Int32.Parse(n_value);
    Int64 result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    Console.WriteLine("\t");
    Console.WriteLine("****  NUMBER  ****");
    Console.Write(n);
    Console.WriteLine("\t");
    Console.WriteLine("****  FACTORIAL  ****");
    Console.Write(result);
}