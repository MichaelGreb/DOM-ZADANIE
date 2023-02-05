// на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Clear();
Console.Write("Введите первое число: ");
int One = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Two = int.Parse(Console.ReadLine());
if(One > Two)
{
    Console.Write(One + " больше " + Two);
}
else
{
    Console.Write(Two + " больше " + One);
}