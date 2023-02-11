// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if(element >= 10 && element <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine(String.Join(", ", array));
int count = CountNumbers(array);
Console.WriteLine(count);