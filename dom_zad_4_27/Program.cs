// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

Console.Clear();
int number = ReadInt("Введите число: ");
int to = NumberTo(number);
SumNumbers(number, to);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberTo(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int to)
{
    int sum = 0;
    for (int i = 1; i <= to; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.Write(sum);
}



