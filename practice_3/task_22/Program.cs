// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();

int count = 1;
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

while (count <= a)
{
    Console.Write(count * count);
    if (count != a)
    {
        Console.Write(", ");
    }
    count++;
}