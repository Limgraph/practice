// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();

string Recursion(int n)
{
    if (n == 1) return n.ToString();
    else
    {
        return Recursion(n - 1) + ", " + n.ToString();
    }
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursion(n));