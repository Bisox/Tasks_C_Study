// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 'a'");
string numA = Console.ReadLine()??" ";
int a = Convert.ToInt32(numA); 

Console.WriteLine("Введите число 'b'");
string numB = Console.ReadLine()??" ";
int b = Convert.ToInt32(numB); 

Console.WriteLine("Введите число 'c'");
string numC = Console.ReadLine()??" ";
int c = Convert.ToInt32(numC);

int maxNum = Math.Max(Math.Max(a, b), c);

Console.WriteLine($"Максимальное число - {maxNum}");