// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число :");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число :");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine($"max = {a}");

else if (b > a && b > c) 
{
Console.WriteLine($"max = {b}");
}
else if (c > b && c > a) 
{
Console.WriteLine($"max = {c}");
}
