// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 0;

Console.WriteLine("Enter number: ");

if(int.TryParse(Console.ReadLine(), out N))
{
    for(int i = 1; i <= N; i++)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}
else
{
    Console.WriteLine("it,s not a number");
}