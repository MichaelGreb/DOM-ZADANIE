// принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int One = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Two = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int Tree = int.Parse(Console.ReadLine());
int Max = int.Parse(Console.ReadLine());
if(One >= Two)
{
    One = Max;
    if(Max >= Tree)
    {
      Console.Write(Max + "- максимальное число ");  
    }
    else
    {
        Console.Write(Tree + "- максимальное число "); 
    }
}
else
{
    Two = Max;
    if(Max >= Tree)
    {
      Console.Write(Max + "- максимальное число ");  
    }
    else
    {
        Console.Write(Tree + "- максимальное число "); 
    }
}
  
  
  
  
  
  
  
   // if(Max > Tree)
    //{
    //    Console.Write(Max + " максимальное число ");
    //}
    //else
    //{
      //  Console.Write(Tree + " максимальное число ");
    //}