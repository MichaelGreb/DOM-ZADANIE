// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int a1 = num / 100;
int a2 = num %10;
int result = ((num - a1*100) - a2)/10;
Console.WriteLine($"{num} -> {result}");

