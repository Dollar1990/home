// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] inputDigit = new double[2, 2];
double[] crossPoint = new double[2];

void InputArray()
{
    for (int i = 0; i < inputDigit.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i + 1}-го уравнения (y = k * x + b)\n");
        for (int j = 0; j < inputDigit.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            inputDigit[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] CrossPointFind(double[,] inputDigit)
{
    crossPoint[0] = (inputDigit[1, 1] - inputDigit[0, 1]) / (inputDigit[0, 0] - inputDigit[1, 0]);
    crossPoint[1] = crossPoint[0] * inputDigit[0, 0] + inputDigit[0, 1];
    return crossPoint;
}

void PrintResult(double[,] inputDigit)
{
    if (inputDigit[0, 0] == inputDigit[1, 0] && inputDigit[0, 1] == inputDigit[1, 1])
    {
        Console.Write("Прямые совпадают");
    }
    else if (inputDigit[0, 0] == inputDigit[1, 0] && inputDigit[0, 1] != inputDigit[1, 1])
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        CrossPointFind(inputDigit);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputArray();
PrintResult(inputDigit);