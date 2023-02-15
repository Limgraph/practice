// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.Clear();

bool Check_three_side(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int z = int.Parse(Console.ReadLine()!);

if(Check_three_side(x,y,z))
{
    Console.WriteLine("Существует!");
}
else
{
    Console.WriteLine("Не существует!");
}