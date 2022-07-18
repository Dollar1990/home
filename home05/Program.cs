// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int dayweek = Convert.ToInt32(Console.ReadLine());
switch (dayweek)
{
    case 1:
        {
            Console.WriteLine($"День недели {dayweek} Понедельник - рабочий");
            break;
        }
    case 2:
        {
            Console.WriteLine($"День недели {dayweek} Вторник - рабочий");
            break;
        }
    case 3:
        {
            Console.WriteLine($"День недели {dayweek} Среда - рабочий");
            break;
        }
    case 4:
        {
            Console.WriteLine($"День недели {dayweek} Четверг - рабочий");
            break;
        }
    case 5:
        {
            Console.WriteLine($"День недели {dayweek} Пятница - рабочий");
            break;
        }
    case 6:
        {
            Console.WriteLine($"День недели {dayweek} Суббота - выходной");
            break;
        }
    case 7:
        {
            Console.WriteLine($"День недели {dayweek} Воскресенье - выходной");
            break;
        }
    default:
        {
            Console.WriteLine($"День недели {dayweek} не существует");
            break;
        }
}