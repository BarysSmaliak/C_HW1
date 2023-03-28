// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a =0, b = 0, c = 0, max = 0;

Console.WriteLine("Enter a, b and c: ");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
{
    max = a;
    if(b > max)
    {
        max = b;
        if (c > max)
        {
            max = c;
        }
    }  
    Console.Write(max);
    Console.WriteLine(" - maximum number");
}
else
{
    Console.WriteLine("it,s not a number, start over");
}
