//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (N <= num)
{
if (N % 2 != 1)
{
Console.Write(N + ", ");
not = false;
}
N++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}