// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Clear();

int[] Fib(int n)
{
    int[] arr = new int[n];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = Fib(n);
Console.WriteLine(string.Join(", ", array));
