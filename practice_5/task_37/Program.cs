// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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

int[] MultiArray(int[] inArray)
{
    int size = inArray.Length / 2;
    if(inArray.Length % 2 != 0)
    {
        size++;
    }
    int[] result = new int[size];
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];
        if(inArray.Length % 2 != 0)
        {
            result[size - 1] = inArray[inArray.Length / 2];
        }
    }
    return result;
}

int[] array = GetArray(5, 0, 10);
Console.WriteLine(String.Join(", ", array));

int[] multiArray = MultiArray(array);
Console.WriteLine(String.Join(", ", multiArray));