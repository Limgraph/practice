// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();
int NumbersPow(int a, int b)
{
    if (b == 0) return 1;
    else return a*NumbersPow(a, b-1);
}
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersPow(a, b));