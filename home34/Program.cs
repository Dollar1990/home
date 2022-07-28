// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] generateArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder + 1);
    }
    return resultArray;
}
void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
int getCountEvenNumbers(int[] array)
{
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0)
        {
        countOdd ++;
        }
    }
    return countOdd;
}
int[] generatedArray = generateArray(4, 99, 999);
ShowArray(generatedArray);
int sumOfOddPositionInArray = getCountEvenNumbers(generatedArray);
Console.WriteLine($"Количество четных чисел в массиве -> {sumOfOddPositionInArray}");