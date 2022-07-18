// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1 

Console.Write("Введите трехзначное число число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
   Console.WriteLine($"Неверный ввод число {number} не трехзначное");
}
else
{
int number2 = (number % 100) / 10;
Console.WriteLine($"{number} -> {number2}");
}
