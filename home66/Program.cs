// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

void SummaryNatural(int m, int n, int summ)
{
    summ = summ + n;
    if (m == n)
    {
        Console.Write($"{summ} ");
    }
    else
    {
        SummaryNatural(m,n-1,summ);

    }
}
Console.Write($"M = {m}; N = {n} -> ");
SummaryNatural(m,n,summ);