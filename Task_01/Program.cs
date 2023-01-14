// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

Console.WriteLine("Введите число 'a'");
string numA = Console.ReadLine()??" ";
int a = Convert.ToInt32(numA); 

Console.WriteLine("Введите число 'b'");
string numB = Console.ReadLine()??" ";
int b = Convert.ToInt32(numB); 

if (a > b)
{
    Console.WriteLine($"maxNum = {a}");
    Console.WriteLine($"minNum = {b}");
}
else
{
    Console.WriteLine($"maxNum = {b}");
    Console.WriteLine($"minNum = {a}");
}