// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите какое количество чисел будет задано: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numberArray = new int[length];

int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int PositiveCount(int[] numberArray)
{
    int count = 0;
    for (int i = 0; i < numberArray.Length; i++)
    {
        if (numberArray[i] > 0)
        {
            count++;
        }
    }
    return count;

}

numberArray = EnterArray(length);
int numberCount = PositiveCount(numberArray);
Console.WriteLine($"Введено чисел больше 0 -> {numberCount}");
