// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.WriteLine("Задайте число N: ");
int userN = int.Parse(Console.ReadLine()!)!;
NaturalNumbers(userN);
void NaturalNumbers (int n)
{
    Console.WriteLine($" {n}");
    if (n == 1)
    {
        return;
    } 
    else
    {
        NaturalNumbers(n-1);
    }
}
