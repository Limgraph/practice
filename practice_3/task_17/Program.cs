Console.Clear();

Console.Write("Введите  X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите  Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (Y > 0)
{
    if (X > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Вторая четверть");
    }
}
else
{
    if (X < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    else
    {
        Console.WriteLine("Четвёртая четверть");
    }
}