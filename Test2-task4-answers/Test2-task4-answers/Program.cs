// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num = 14;
int guess;
do
{
    guess = int.Parse(Console.ReadLine());
    if (guess > num)
    {
        Console.WriteLine("Your guess is higher");
    }
    else if (guess < num)
    {
        Console.WriteLine("Your guess is lower");
    }
} while (guess != num);
Console.WriteLine("You win");