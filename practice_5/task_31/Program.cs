//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
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

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positive = 0;
int negative = 0;

foreach (int element in array)
{
//     if(element > 0)
//     {
//         positive += element;
//     }
    positive += element > 0 ? element : 0;
    negative += element < 0 ? element : 0;
}

Console.WriteLine($"Сумма положительных равна {positive}, сумма отрицательных равна {negative}.");