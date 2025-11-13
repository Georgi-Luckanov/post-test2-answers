// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = int.Parse(Console.ReadLine());
if (num < 0)
    Console.WriteLine("Error");
else
{
    double sum = 1;
    if (num == 0)
    {
        Console.WriteLine(1);
    }
    else
    {
        int product = 1;
        for (int i = num; i > 0; i--)
        {
            product = product * i;
        }
        Console.WriteLine(sum);
    }
}