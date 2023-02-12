// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int N = number.Length;

if (N == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Число является палиндромным");
    }
    else
    {
        Console.WriteLine($"{number} - Число не является палиндромным");
    }
}
else
{
    Console.WriteLine($"Число {number} - не является пятизначным");
}
