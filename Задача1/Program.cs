//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 2;
int b = 10;

int max = a;
int min = a;

if (b > max) max = b;
if (max > min) min = a;

Console.Write("max:");
Console.WriteLine(max);
Console.Write("min:");
Console.WriteLine(min);