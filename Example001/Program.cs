// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a;
int b;

Console.WriteLine("Enter a and b: ");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
    if(a!=b)
    {
        if (a > b)
        {
            Console.Write(a);
            Console.WriteLine(" - this number is greater");
            Console.Write(b);
            Console.WriteLine(" - this number is less");
        }
        else
        {
            Console.Write(b);
            Console.WriteLine(" - this number is greater");
            Console.Write(a);
            Console.WriteLine(" - this number is less");
        }
    }
    else
    {
        Console.WriteLine("these numbers are equal");
    }
}
else
{
    Console.WriteLine("a or b is not a number");
}
