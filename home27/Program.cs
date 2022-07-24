// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumDigit(int digit)
{
    int sumDigit = 0;
    while (digit > 0)
    {
        sumDigit = sumDigit + digit % 10;
        digit = digit / 10;
    }
    return sumDigit;
}

Console.Write("Введите число в котором будем считать сумму всех цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр в числе {number} -> {SumDigit(number)}");