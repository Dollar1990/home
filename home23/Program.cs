// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число для получения таблицы кубов от 1 до N ");
int N = Convert.ToInt32(Console.ReadLine());
int i;
double cube;
Console.Write($"{N} -> ");
for (i = 1; i <= N-1; i++)
{
    cube = Math.Pow(i, 3);
    Console.Write($"{cube}, ");
}
cube = Math.Pow(i, 3);
    Console.Write($"{cube} ");