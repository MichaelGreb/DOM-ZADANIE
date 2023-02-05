// на вход принимает число (N), а на выходе показывает все 
// чётные числа от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int P = 1;
while(P <= N)
    {
        Console.Write(P + " ");
        P++;
    }
