//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 3;
int b = 44;
int c = 9;

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;


Console.Write("max:");
Console.WriteLine(max);