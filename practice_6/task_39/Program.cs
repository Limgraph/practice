//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

int[] GetArray(int size, int min_value, int max_value)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min_value, max_value +1);
    }
    return res;
}

void Revers_array_1(int[] in_array)
{
    for (int i = 0; i < in_array.Length/2; i++)
    {
        int temp = in_array[i];
        in_array[i] = in_array[in_array.Length -1 - i];
        in_array[in_array.Length -1 - i] = temp;
    }
}

int[] Revers_array_2(int[] in_array)
{
    int[] result = new int[in_array.Length];
    for (int i = 0; i < in_array.Length; i++)
    {
        result[i] = in_array[in_array.Length -1 -i];
    }
    return result;
}

int[] array = GetArray(7, 0, 10);
Console.WriteLine(String.Join(", ", array));
Revers_array_1(array);
Console.WriteLine(String.Join(", ", array));
int[] reversed = Revers_array_2(array);
Console.WriteLine(String.Join(", ", reversed));