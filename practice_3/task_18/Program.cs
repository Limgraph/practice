//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите номер четверть: ");
int x = int.Parse(Console.ReadLine()!);

switch (x)
{
    case 1:
        Console.Write("X > 0 || Y > 0");
        break;
    case 2:
        Console.Write("X < 0 || Y > 0");
        break;
    case 3:
        Console.Write("X < 0 || Y < 0");
        break;
    case 4:
        Console.Write("X > 0 || Y < 0");
        break;
    default:
        Console.Write("Вы ввели неправильный номер четверти!");
        break;
}