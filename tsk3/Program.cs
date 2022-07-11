Console.WriteLine("Введите день недели");
int dayweek = Convert.ToInt32(Console.ReadLine());
switch (dayweek)
{
    case 1:
        {
            Console.WriteLine($"День недели {dayweek} понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine($"День недели {dayweek} Вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine($"День недели {dayweek} Среда");
            break;
        }
    case 4:
        {
            Console.WriteLine($"День недели {dayweek} Четверг");
            break;
        }
    case 5:
        {
            Console.WriteLine($"День недели {dayweek} Пятница ");
            break;
        }
    case 6:
        {
            Console.WriteLine($"День недели {dayweek} Суббота");
            break;
        }
    case 7:
        {
            Console.WriteLine($"День недели {dayweek} Воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine($"День недели {dayweek} не существует");
            break;
        }
}