// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
// ли этот день выходным

Console.Clear();
Console.Write("Введите день недели: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
    {
        Console.Write("нет");
    }
if(number == 2)
    {
        Console.Write("нет");
    }
if(number == 3)
    {
        Console.Write("нет");
    }
if(number == 4)
    {
        Console.Write("нет");
    }
if(number == 5)
    {
        Console.Write("нет");
    }
if(number == 6)
    {
        Console.Write("да");
    }
if(number == 7)
    {
        Console.Write("да");
    }
if(number > 7)
    {
        Console.Write("значение неверно");
    }
    if(number < 1)
    {
        Console.Write("значение неверно");
    }