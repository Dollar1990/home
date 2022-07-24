// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] GetRandomArray()
{
    int[] array = new int [8];
    for (int i = 0; i < 8; i++)
    {
        array[i]= new Random().Next(0,100);
    }
    return array;
}
void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[7]}]");
}
int [] array = new int [8];
array = GetRandomArray();
PrintArray(array);



// Console.Write("Введите число 1 для создания массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 для создания массива: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 3 для создания массива: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 4 для создания массива: ");
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 5 для создания массива: ");
// int num5 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 6 для создания массива: ");
// int num6 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 7 для создания массива: ");
// int num7 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 8 для создания массива: ");
// int num8 = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[] {num1,num2,num3,num4,num5,num6,num7,num8};
// void PrintArray(int [] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine($"{array[7]}]");
// }
// PrintArray(Array);
