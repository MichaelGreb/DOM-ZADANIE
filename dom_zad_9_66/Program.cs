//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);
