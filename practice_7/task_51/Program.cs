//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.Clear();

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");//'\t' - табуляция; \n перенос на следующую строку; Escape последовательность, управляющая последовательность
        }
        Console.WriteLine();
    }
}

int ConvertArray(int[,] arr)
{
    int sum = 0;
    int size = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);//тернарный оператор

    for (int i = 0; i < size; i++)
    {
        sum += arr[i, i];
    }

    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < arr.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //             sum = sum + arr[i, j];
    //         }
    //     }
    // }
    return sum;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 1, 10);
PrintArray(array2D);
int summa = ConvertArray(array2D);
Console.Write(summa);