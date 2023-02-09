// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = number;
int result = 0;
if (number<100)
{
Console.Write("Третьей цифры нет");
return;
}
else
{
    while(number>=1000)
    {
        number = number / 10;
    }
    result = number % 10;
}
Console.WriteLine(result);


