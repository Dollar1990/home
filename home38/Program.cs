// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] generateArray(int length, int startBorder, int endBorder)
{
    double[] resultArray = new double[length];
    for (var i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder + 1);
    }
    return resultArray;
}
void ShowArray(double[] arrayToShow)
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
double getRangeMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double minMaxDiff = max - min;
    return minMaxDiff;

}
double[] generatedArray = generateArray(6, 0, 99);
ShowArray(generatedArray);
double minMaxRange = getRangeMinMax(generatedArray);
Console.WriteLine($"Разница между максимальным числом массива и минимальным = {minMaxRange}");
