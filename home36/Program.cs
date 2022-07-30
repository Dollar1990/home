// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] generateArray(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder+1);
        }
        return resultArray;
}
void ShowArray(int[] arrayToShow)
{
     Console.Write("[");
    for (var i = 0; i < arrayToShow.Length; i++)
    {
       Console.Write(arrayToShow[i]);
       if (i<arrayToShow.Length -1)
       {
        Console.Write(", ");
       } 
    }
     Console.Write("]");
     Console.WriteLine();
}
int getSumOfOddPosition(int[] array)
{
    int sumOfArray = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
sumOfArray += array[i];
    }
    return sumOfArray;
}
int[]  generatedArray = generateArray(6,-9,9);
ShowArray(generatedArray);
int sumOfOddPositionInArray = getSumOfOddPosition(generatedArray);
Console.WriteLine($"Сумма нечетных элементов массива = {sumOfOddPositionInArray}");