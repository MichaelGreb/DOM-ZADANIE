// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет

Console.Clear();
Console.Write("Введите трехзначное число: ))");
int number = int.Parse(Console.ReadLine());
Console.Write(number%10);

