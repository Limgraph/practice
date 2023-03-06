// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();

int Numbers(int n)
{
    if (n == 0) return 0;
    else return n % 10 + Numbers(n / 10);
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Numbers(n));