//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 44;
int b = 5;
int c = 78;

int max = a;

if(b > max) max = b;
    while(b < max); max = a;
if(c > max) max = c;
    while(c < max); max = a;

Console.Write("max:");
Console.WriteLine(max);