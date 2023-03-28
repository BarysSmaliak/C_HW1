// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = 0, remainder = 0;

Console.WriteLine("Enter number: ");

if (int.TryParse(Console.ReadLine(), out number))
{
    remainder = number % 2;
    if(remainder == 0)
    {
        Console.WriteLine("number is even");
    }
    else
    {
        Console.WriteLine("number is odd");
    }
}
else
{
    Console.WriteLine("it,s not a number");
}
