﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintNatural(int n, int count = 1)
{
    if (count == n)
    {
        Console.Write($"{n} ");
    }
    else
    {
        Console.Write($"{count}, ");
        PrintNatural(n, count +1);

    }
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {m}; N = {n} -> ");
PrintNatural(n,m);
